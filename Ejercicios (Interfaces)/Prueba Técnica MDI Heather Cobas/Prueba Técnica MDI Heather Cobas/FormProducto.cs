using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Prueba_Técnica_MDI_Heather_Cobas
{
    public partial class FormProducto : Form
    {
        private readonly string rutaArchivo = @"C:\Users\pc\source\repos\Ejercicios (Interfaces)\Prueba Técnica MDI Heather Cobas\Productos\Productos.txt";

        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
            CargarDatosDesdeArchivo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cmbCategoria.Text) ||
                string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                string categoria = cmbCategoria.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                int stock = int.Parse(txtStock.Text);

                DGVProductos.Rows.Add(nombre, categoria, precio, stock);

                using (StreamWriter file = new StreamWriter(rutaArchivo, true))
                {
                    file.WriteLine($"{nombre},{categoria},{precio},{stock}");
                }

                MessageBox.Show("Producto guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numéricos válidos en Precio y Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DGVProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = DGVProductos.SelectedRows[0];

                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                cmbCategoria.Text = filaSeleccionada.Cells["Categoria"].Value.ToString();
                txtPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                txtStock.Text = filaSeleccionada.Cells["Stock"].Value.ToString();

                DGVProductos.Rows.Remove(filaSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVProductos.SelectedRows.Count > 0)
            {
                string nombre = DGVProductos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string categoria = DGVProductos.SelectedRows[0].Cells["Categoria"].Value.ToString();
                decimal precio = decimal.Parse(DGVProductos.SelectedRows[0].Cells["Precio"].Value.ToString());
                int stock = int.Parse(DGVProductos.SelectedRows[0].Cells["Stock"].Value.ToString());

                DGVProductos.Rows.RemoveAt(DGVProductos.SelectedRows[0].Index);

                EliminarProductoDelArchivo(nombre, categoria, precio, stock);

                MessageBox.Show("Producto eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarProductoDelArchivo(string nombre, string categoria, decimal precio, int stock)
        {
            if (File.Exists(rutaArchivo))
            {
                var lines = File.ReadAllLines(rutaArchivo).ToList();
                string lineaAEliminar = $"{nombre},{categoria},{precio},{stock}";

                lines.Remove(lineaAEliminar);

                File.WriteAllLines(rutaArchivo, lines);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtNombre.Text.ToLower();

            foreach (DataGridViewRow fila in DGVProductos.Rows)
            {
                if (fila.IsNewRow) continue;

                bool coincide = fila.Cells["Nombre"].Value.ToString().ToLower().Contains(busqueda);
                fila.Visible = coincide;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in DGVProductos.Rows)
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
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void ActualizarDataGridView()
        {
            DGVProductos.Rows.Clear();
        }

        private void CargarDatosDesdeArchivo()
        {
            if (File.Exists(rutaArchivo))
            {
                string[] lines = File.ReadAllLines(rutaArchivo);

                foreach (string line in lines)
                {
                    string[] datos = line.Split(',');

                    if (datos.Length == 4)
                    {
                        string nombre = datos[0];
                        string categoria = datos[1];
                        decimal precio = decimal.Parse(datos[2]);
                        int stock = int.Parse(datos[3]);

                        DGVProductos.Rows.Add(nombre, categoria, precio, stock);
                    }
                }
            }
        }
    }
}
