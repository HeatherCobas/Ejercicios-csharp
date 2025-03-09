using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Capa_Negocio;


namespace CapaPresentacion
{
    public partial class Form_P : Form
    {
        private N_Producto negocioProductos = new N_Producto();
        private int? selectedProductId = null;


        public Form_P()
        {
            InitializeComponent();
            MostrarProductos();
            CargarCategorias();
            CargarMedidas();
            DesactivarCampos();
            ConfigurarDataGridView();

            BtnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            DGV.CellClick += DGV_CellClick;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ActivarCampos();
            LimpiarCampos();
            txtDescripcion.Focus();
            BtnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (!selectedProductId.HasValue)
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                string connectionString = @"Server=DESKTOP-5RJ08CB;Database=ProductoDB;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_Guardar_pr", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id_prod", selectedProductId.Value);
                        command.Parameters.AddWithValue("@Nombre_Prod", txtProducto.Text);
                        command.Parameters.AddWithValue("@Marca", txtMarca.Text);
                        command.Parameters.AddWithValue("@Id_Medida", cmbMedida.SelectedValue);
                        command.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                        command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                        command.Parameters.AddWithValue("@Id_cat", cmbCategoria.SelectedValue);
                        command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        command.Parameters.AddWithValue("@opcion", 2);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarProductos();
                LimpiarCampos();
                DesactivarCampos();
                ResetearBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el producto seleccionado?",
                                                  "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int idProducto = Convert.ToInt32(DGV.SelectedRows[0].Cells["Id_Prod"].Value);

                    string connectionString = @"Server=DESKTOP-5RJ08CB;Database=ProductoDB;Trusted_Connection=True;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("sp_EliminarProducto", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Id_Prod", idProducto);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Producto eliminado correctamente.");
                    MostrarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) return;

                string connectionString = @"Server=DESKTOP-5RJ08CB;Database=ProductoDB;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_Guardar_pr", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre_Prod", txtProducto.Text);
                        command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                        command.Parameters.AddWithValue("@Marca", txtMarca.Text);
                        command.Parameters.AddWithValue("@Id_Medida", cmbMedida.SelectedValue);
                        command.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                        command.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                        command.Parameters.AddWithValue("@Id_cat", cmbCategoria.SelectedValue);
                        command.Parameters.AddWithValue("@opcion", 1);
                        command.Parameters.AddWithValue("@id_prod", DBNull.Value);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Producto guardado con éxito.");
                MostrarProductos();
                LimpiarCampos();
                DesactivarCampos();
                BtnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnNuevo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtProducto.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            cmbMedida.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            txtStock.Clear();

            BtnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string valorBusqueda = txtBuscador.Text.Trim();
                DataTable dt = negocioProductos.ListarProductos(valorBusqueda);
                DGV.DataSource = dt;

                if (dt.Rows.Count == 0 && !string.IsNullOrEmpty(valorBusqueda))
                {
                    DGV.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGV.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = DGV.Rows[e.RowIndex];
                if (selectedRow != null)
                {
                    selectedProductId = Convert.ToInt32(selectedRow.Cells["Id_Prod"].Value);
                    txtProducto.Text = selectedRow.Cells["Nombre_Prod"].Value.ToString();
                    txtDescripcion.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                    txtMarca.Text = selectedRow.Cells["Marca"].Value.ToString();
                    cmbMedida.SelectedValue = selectedRow.Cells["Id_Medida"].Value;
                    txtStock.Text = selectedRow.Cells["Stock"].Value.ToString();
                    txtPrecio.Text = selectedRow.Cells["Precio"].Value.ToString();
                    cmbCategoria.SelectedValue = selectedRow.Cells["Id_cat"].Value;

                    ActivarCampos();
                    btnactualizar.Enabled = true;
                    btnDelete.Enabled = true;
                    BtnGuardar.Enabled = false;
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text) ||
               string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
               string.IsNullOrWhiteSpace(txtMarca.Text) ||
               cmbMedida.SelectedIndex == -1 ||
               cmbCategoria.SelectedIndex == -1 ||
               string.IsNullOrWhiteSpace(txtPrecio.Text) ||
               string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0 || precio > 9999999.99m)
            {
                MessageBox.Show("El precio debe ser un número válido entre 0 y 9,999,999.99", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0 || stock > 999999999)
            {
                MessageBox.Show("El stock debe ser un número entero válido entre 0 y 999,999,999", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable dtCategorias = negocioProductos.ListarCategorias();
                if (dtCategorias.Rows.Count > 0)
                {
                    cmbCategoria.DataSource = dtCategorias;
                    cmbCategoria.DisplayMember = "Nombre_cat";
                    cmbCategoria.ValueMember = "Id_cat";
                    cmbCategoria.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay categorías disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}");
            }
        }

        private void MostrarProductos()
        {
            try
            {
                DGV.AutoGenerateColumns = false;
                DataTable dt = negocioProductos.ListarProductos("");
                DGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ConfigurarDataGridView()
        {
            DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV.MultiSelect = false;
            DGV.ReadOnly = true;
            DGV.AllowUserToAddRows = false;
            DGV.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            DGV.Columns.Clear();
            DGV.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "Id_Prod", DataPropertyName = "Id_Prod", HeaderText = "ID_Prod", Visible = true },
                new DataGridViewTextBoxColumn { Name = "Nombre_Prod", DataPropertyName = "Nombre_Prod", HeaderText = "Nombre del Producto" },
                new DataGridViewTextBoxColumn { Name = "Descripcion", DataPropertyName = "Descripcion", HeaderText = "Descripción" },
                new DataGridViewTextBoxColumn { Name = "Marca", DataPropertyName = "Marca", HeaderText = "Marca" },
                new DataGridViewTextBoxColumn { Name = "Id_Medida", DataPropertyName = "Id_Medida", HeaderText = "ID Medida", Visible = false },
                new DataGridViewTextBoxColumn { Name = "Nombre_Me", DataPropertyName = "Nombre_Me", HeaderText = "Medida" },
                new DataGridViewTextBoxColumn { Name = "Stock", DataPropertyName = "Stock", HeaderText = "Stock" },
                new DataGridViewTextBoxColumn { Name = "Precio", DataPropertyName = "Precio", HeaderText = "Precio" },
                new DataGridViewTextBoxColumn { Name = "Id_cat", DataPropertyName = "Id_cat", HeaderText = "ID Categoría", Visible = false },
                new DataGridViewTextBoxColumn { Name = "Nombre_cat", DataPropertyName = "Nombre_cat", HeaderText = "Categoría" }
            );
        }

        private void ResetearBotones()
        {
            btnactualizar.Enabled = false;
            btnDelete.Enabled = false;
            btnNuevo.Enabled = true;
            BtnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            selectedProductId = null;
        }

        private void LimpiarCampos()
        {
            selectedProductId = null;
            txtProducto.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            cmbMedida.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void ActivarCampos()
        {
            txtProducto.Enabled = true;
            txtDescripcion.Enabled = true;
            txtMarca.Enabled = true;
            cmbMedida.Enabled = true;
            cmbCategoria.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
        }

        private void DesactivarCampos()
        {
            txtProducto.Enabled = false;
            txtDescripcion.Enabled = false;
            txtMarca.Enabled = false;
            cmbMedida.Enabled = false;
            cmbCategoria.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
        }

        private void CargarMedidas()
        {
            try
            {
                DataTable dtMedidas = negocioProductos.ListarMedidas();
                if (dtMedidas.Rows.Count > 0)
                {
                    cmbMedida.DataSource = dtMedidas;
                    cmbMedida.DisplayMember = "Nombre_Me";
                    cmbMedida.ValueMember = "Id_Medida";
                    cmbMedida.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("No hay medidas disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar medidas: {ex.Message}");
            }
        }
    }
}