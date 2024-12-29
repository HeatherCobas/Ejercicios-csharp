using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Prueba_Técnica_MDI_Heather_Cobas
{
    public partial class FormProveedor : Form
    {
        private readonly string rutaArchivo = @"C:\Users\pc\source\repos\Ejercicios (Interfaces)\Prueba Técnica MDI Heather Cobas\Proveedores\Proveedores.txt";

        public FormProveedor()
        {
            InitializeComponent();
            CargarDatosDesdeArchivo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRNC.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios: Nombre y RNC.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string rnc = txtRNC.Text.Trim();
                string direccion = txtDirección.Text.Trim();
                string telefono = txtTeléfono.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string ciudad = cmbCiudad.Text.Trim();

                DGVProveedor.Rows.Add(nombre, apellido, rnc, direccion, telefono, correo, ciudad);

                using (StreamWriter file = new StreamWriter(rutaArchivo, true))
                {
                    file.WriteLine($"{nombre},{apellido},{rnc},{direccion},{telefono},{correo},{ciudad}");
                }

                MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DGVProveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DGVProveedor.SelectedRows[0];

                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                txtRNC.Text = filaSeleccionada.Cells["RNC"].Value.ToString();
                txtDirección.Text = filaSeleccionada.Cells["Dirección"].Value.ToString();
                txtTeléfono.Text = filaSeleccionada.Cells["Teléfono"].Value.ToString();
                txtCorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                cmbCiudad.Text = filaSeleccionada.Cells["Ciudad"].Value.ToString();

                DGVProveedor.Rows.Remove(filaSeleccionada);
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVProveedor.SelectedRows.Count > 0)
            {
                string nombre = DGVProveedor.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string apellido = DGVProveedor.SelectedRows[0].Cells["Apellido"].Value.ToString();
                string rnc = DGVProveedor.SelectedRows[0].Cells["RNC"].Value.ToString();
                string direccion = DGVProveedor.SelectedRows[0].Cells["Dirección"].Value.ToString();
                string telefono = DGVProveedor.SelectedRows[0].Cells["Teléfono"].Value.ToString();
                string correo = DGVProveedor.SelectedRows[0].Cells["Correo"].Value.ToString();
                string ciudad = DGVProveedor.SelectedRows[0].Cells["Ciudad"].Value.ToString();

                DGVProveedor.Rows.RemoveAt(DGVProveedor.SelectedRows[0].Index);

                EliminarProveedorDelArchivo(nombre, apellido, rnc, direccion, telefono, correo, ciudad);

                MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarProveedorDelArchivo(string nombre, string apellido, string rnc, string direccion, string telefono, string correo, string ciudad)
        {
            if (File.Exists(rutaArchivo))
            {
                var lines = File.ReadAllLines(rutaArchivo).ToList();
                string lineaAEliminar = $"{nombre},{apellido},{rnc},{direccion},{telefono},{correo},{ciudad}";

                lines.Remove(lineaAEliminar);

                File.WriteAllLines(rutaArchivo, lines);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtNombre.Text.ToLower();

            foreach (DataGridViewRow fila in DGVProveedor.Rows)
            {
                if (fila.IsNewRow) continue;

                bool coincide = fila.Cells["Nombre"].Value.ToString().ToLower().Contains(busqueda);
                fila.Visible = coincide;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in DGVProveedor.Rows)
            {
                fila.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtRNC.Clear();
            txtDirección.Clear();
            txtTeléfono.Clear();
            txtCorreo.Clear();
            cmbCiudad.SelectedIndex = -1;
        }

        private void ActualizarDataGridView()
        {
            DGVProveedor.Rows.Clear();
        }

        private void CargarDatosDesdeArchivo()
        {
            if (File.Exists(rutaArchivo))
            {
                string[] lines = File.ReadAllLines(rutaArchivo);

                foreach (string line in lines)
                {
                    string[] datos = line.Split(',');

                    if (datos.Length == 7)
                    {
                        string nombre = datos[0];
                        string apellido = datos[1];
                        string rnc = datos[2];
                        string direccion = datos[3];
                        string telefono = datos[4];
                        string correo = datos[5];
                        string ciudad = datos[6];

                        DGVProveedor.Rows.Add(nombre, apellido, rnc, direccion, telefono, correo, ciudad);
                    }
                }
            }
        }
    }
}