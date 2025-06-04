using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Act.Inicio_de_Sesion
{
    public partial class FrmGestionPersonas : Form
    {
        private int idPersonaSeleccionada = 0;
        private bool esNuevo = true;

        public FrmGestionPersonas()
        {
            InitializeComponent();
        }

        private void FrmGestionPersonas_Load(object sender, EventArgs e)
        {

            lblUsuarioActual.Text = $"Usuario: {Session.NombreCompleto}";
            ConfigurarControles(false);
            CargarPersonas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ConfigurarControles(true);
            esNuevo = true;
            txtCedula.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar datos
                if (!ValidarDatos())
                {
                    return;
                }

                if (esNuevo)
                {
                    // Insertar nueva persona
                    if (InsertarPersona())
                    {
                        MessageBox.Show("Persona registrada correctamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        ConfigurarControles(false);
                        CargarPersonas();
                    }
                }
                else
                {
                    // Actualizar persona existente
                    if (ActualizarPersona())
                    {
                        MessageBox.Show("Datos actualizados correctamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        ConfigurarControles(false);
                        CargarPersonas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPersonaSeleccionada <= 0)
                {
                    MessageBox.Show("Debe seleccionar una persona para eliminar", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (EliminarPersona())
                    {
                        MessageBox.Show("Persona eliminada correctamente", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        ConfigurarControles(false);
                        CargarPersonas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            ConfigurarControles(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarPersonas(txtBuscar.Text);
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPersonaSeleccionada = Convert.ToInt32(dgvPersonas.Rows[e.RowIndex].Cells["Id_Persona"].Value);
                CargarDatosPersona(idPersonaSeleccionada);
                ConfigurarControles(true);
                esNuevo = false;
                txtCedula.Enabled = false; // No permitir cambiar la cédula
            }
        }

        // Métodos auxiliares
        private void ConfigurarControles(bool habilitado)
        {
            // Habilitar o deshabilitar controles según el estado
            txtCedula.Enabled = habilitado;
            txtNombres.Enabled = habilitado;
            txtApellidos.Enabled = habilitado;
            dtpFechaNacimiento.Enabled = habilitado;
            cboGenero.Enabled = habilitado;
            txtDireccion.Enabled = habilitado;
            txtTelefono.Enabled = habilitado;
            txtEmail.Enabled = habilitado;

            btnGuardar.Enabled = habilitado;
            btnCancelar.Enabled = habilitado;

            btnNuevo.Enabled = !habilitado;
            btnEliminar.Enabled = !habilitado && idPersonaSeleccionada > 0;
        }

        private void LimpiarFormulario()
        {
            txtCedula.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            dtpFechaNacimiento.Value = DateTime.Now.AddYears(-18);
            cboGenero.SelectedIndex = -1;
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();

            idPersonaSeleccionada = 0;
            esNuevo = true;
        }

        private bool ValidarDatos()
        {
            // Validar campos obligatorios
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Debe ingresar la cédula", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCedula.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                MessageBox.Show("Debe ingresar los nombres", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Debe ingresar los apellidos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return false;
            }

            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el género", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGenero.Focus();
                return false;
            }

            // Validar email (si se ha ingresado)
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(txtEmail.Text);
                }
                catch
                {
                    MessageBox.Show("El correo electrónico no tiene un formato válido", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            return true;
        }

        private void CargarPersonas(string filtro = "")
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();

                    SqlCommand cmd;
                    if (string.IsNullOrEmpty(filtro))
                    {
                        cmd = new SqlCommand("SP_ListarPersonas", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                    else
                    {
                        cmd = new SqlCommand("SP_BuscarPersonas", conexion);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Filtro", filtro);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPersonas.DataSource = dt;

                    // Configurar columnas del DataGridView
                    if (dgvPersonas.Columns.Contains("Id_Persona"))
                    {
                        dgvPersonas.Columns["Id_Persona"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosPersona(int idPersona)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_ObtenerPersona", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPersona", idPersona);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCedula.Text = reader["Cedula"].ToString();
                                txtNombres.Text = reader["Nombres"].ToString();
                                txtApellidos.Text = reader["Apellidos"].ToString();
                                dtpFechaNacimiento.Value = Convert.ToDateTime(reader["Fecha_Nacimiento"]);

                                string genero = reader["Genero"].ToString();
                                switch (genero)
                                {
                                    case "M":
                                        cboGenero.SelectedIndex = 0; // Masculino
                                        break;
                                    case "F":
                                        cboGenero.SelectedIndex = 1; // Femenino
                                        break;
                                    case "O":
                                        cboGenero.SelectedIndex = 2; // Otro
                                        break;
                                }

                                txtDireccion.Text = reader["Direccion"].ToString();
                                txtTelefono.Text = reader["Telefono"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de la persona: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InsertarPersona()
        {
            bool resultado = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_InsertarPersona", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text.Trim());
                        cmd.Parameters.AddWithValue("@Nombres", txtNombres.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text.Trim());
                        cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.Date);

                        string genero = "O";
                        switch (cboGenero.SelectedIndex)
                        {
                            case 0:
                                genero = "M"; // Masculino
                                break;
                            case 1:
                                genero = "F"; // Femenino
                                break;
                            case 2:
                                genero = "O"; // Otro
                                break;
                        }
                        cmd.Parameters.AddWithValue("@Genero", genero);

                        cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(txtDireccion.Text) ? DBNull.Value : (object)txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(txtTelefono.Text) ? DBNull.Value : (object)txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(txtEmail.Text) ? DBNull.Value : (object)txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@IdUsuarioRegistro", Session.IdUsuario);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                resultado = Convert.ToBoolean(reader["Resultado"]);
                                string mensaje = reader["Mensaje"].ToString();

                                if (!resultado)
                                {
                                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar persona: " + ex.Message);
            }

            return resultado;
        }

        private bool ActualizarPersona()
        {
            bool resultado = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_ActualizarPersona", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdPersona", idPersonaSeleccionada);
                        cmd.Parameters.AddWithValue("@Nombres", txtNombres.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text.Trim());
                        cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value.Date);

                        string genero = "O";
                        switch (cboGenero.SelectedIndex)
                        {
                            case 0:
                                genero = "M"; // Masculino
                                break;
                            case 1:
                                genero = "F"; // Femenino
                                break;
                            case 2:
                                genero = "O"; // Otro
                                break;
                        }
                        cmd.Parameters.AddWithValue("@Genero", genero);

                        cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(txtDireccion.Text) ? DBNull.Value : (object)txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(txtTelefono.Text) ? DBNull.Value : (object)txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(txtEmail.Text) ? DBNull.Value : (object)txtEmail.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                resultado = Convert.ToBoolean(reader["Resultado"]);
                                string mensaje = reader["Mensaje"].ToString();

                                if (!resultado)
                                {
                                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar persona: " + ex.Message);
            }

            return resultado;
        }

        private bool EliminarPersona()
        {
            bool resultado = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection(ObtenerCadenaConexion()))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_EliminarPersona", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPersona", idPersonaSeleccionada);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                resultado = Convert.ToBoolean(reader["Resultado"]);
                                string mensaje = reader["Mensaje"].ToString();

                                if (!resultado)
                                {
                                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar persona: " + ex.Message);
            }

            return resultado;
        }

        // Método para obtener la cadena de conexión
        private string ObtenerCadenaConexion()
        {
            // En un entorno de producción, esta cadena debería estar en un archivo de configuración
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=DB_SistemaLogin;Integrated Security=True";
        }
    }
}