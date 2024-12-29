using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;

        public Form1()
        {
            InitializeComponent();
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            listaArticulos = new List<Articulo>
    {
        new Articulo("001", "Producto A", 50.00m),
        new Articulo("002", "Producto B", 30.00m),
        new Articulo("003", "Producto C", 70.00m),
        new Articulo("004", "Producto D", 100.00m)
    };

            cmbArticulos.Items.Clear();
            cmbArticulos.Items.AddRange(listaArticulos.ConvertAll(a => $"{a.Codigo} - {a.Nombre}").ToArray());
            cmbArticulos.SelectedIndexChanged += cmbArticulos_SelectedIndexChanged;
        }

        private void cmbArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex != -1)
            {
                Articulo articuloSeleccionado = listaArticulos[cmbArticulos.SelectedIndex];
                txtCodigo.Text = articuloSeleccionado.Codigo;
                txtPrecio.Text = articuloSeleccionado.Precio.ToString("0.00");
            }
            else
            {
                txtCodigo.Clear();
                txtPrecio.Clear();
            }
        }


        private void ActualizarCambio()
        {
            if (decimal.TryParse(txtMonto.Text, out decimal efectivo) &&
                decimal.TryParse(txtTotal.Text, out decimal total))
            {
                decimal cambio = efectivo - total;
                txtCambio.Text = cambio >= 0 ? cambio.ToString("0.00") : "0.00";
            }
            else
            {
                txtCambio.Text = "0.00";
            }
        }

        private void ActualizarTotal()
        {
            try
            {
                decimal total = 0;
                foreach (DataGridViewRow row in DGVArticulos.Rows)
                {
                    if (row.Cells["Total"].Value != null)
                    {
                        total += decimal.Parse(row.Cells["Total"].Value.ToString());
                    }
                }
                txtTotal.Text = total.ToString("0.00");

                ActualizarCambio();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al calcular el total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            cmbArticulos.SelectedIndex = -1;
            txtCodigo.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtMonto.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtTotal.Text = "0.00";
            txtMonto.Clear();
            txtCambio.Text = "0.00";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Articulo articulo = listaArticulos[cmbArticulos.SelectedIndex];
            decimal total = articulo.Precio * cantidad;

            decimal monto = 0;
            if (decimal.TryParse(txtMonto.Text, out monto) && monto >= 0)
            {
            }
            else
            {
                monto = total;
            }

            decimal cambio = 0;
            if (decimal.TryParse(txtMonto.Text, out decimal efectivo))
            {
                cambio = efectivo - total;
            }

            DGVArticulos.Rows.Add(
                articulo.Codigo,
                articulo.Nombre,
                cantidad,
                articulo.Precio.ToString("0.00"),
                total.ToString("0.00"),
                monto.ToString("0.00"),
                cambio >= 0 ? cambio.ToString("0.00") : "0.00"
            );

       

            ActualizarTotal();
            LimpiarCampos();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbArticulos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Articulo articulo = listaArticulos[cmbArticulos.SelectedIndex];
            decimal total = articulo.Precio * cantidad;

            txtTotal.Text = total.ToString("0.00");

            ActualizarCambio();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (DGVArticulos.Rows.Count == 0)
            {
                MessageBox.Show("No hay artículos para facturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo de texto (*.txt)|*.txt",
                FileName = $"Factura_{DateTime.Now:yyyyMMdd_HHmmss}"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {

                        writer.WriteLine("FACTURA DE VENTA");
                        writer.WriteLine("================");
                        writer.WriteLine($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                        writer.WriteLine();

                        writer.WriteLine("DETALLE DE PRODUCTOS");
                        writer.WriteLine(String.Format("{0,-10} {1,-20} {2,-8} {3,-10} {4,-10} {5,-10} {6,-10}",
                            "Código", "Nombre", "Cant", "Precio", "Total", "Monto", "Cambio"));
                        writer.WriteLine(new string('-', 80));

                        foreach (DataGridViewRow row in DGVArticulos.Rows)
                        {
                            if (!row.IsNewRow && row.Cells[0].Value != null)
                            {
                                writer.WriteLine(String.Format("{0,-10} {1,-20} {2,-8} {3,-10:C2} {4,-10:C2} {5,-10:C2} {6,-10:C2}",
                                    row.Cells[0].Value,
                                    row.Cells[1].Value,
                                    row.Cells[2].Value,
                                    decimal.Parse(row.Cells[3].Value.ToString()),
                                    decimal.Parse(row.Cells[4].Value.ToString()),
                                    decimal.Parse(row.Cells[5].Value.ToString()),
                                    decimal.Parse(row.Cells[6].Value.ToString())
                                ));
                            }
                        }

                        writer.WriteLine(new string('-', 80));
                        writer.WriteLine($"TOTAL:    {decimal.Parse(txtTotal.Text):C2}");
                        if (!string.IsNullOrEmpty(txtMonto.Text))
                            writer.WriteLine($"EFECTIVO: {decimal.Parse(txtMonto.Text):C2}");
                        writer.WriteLine($"CAMBIO:   {decimal.Parse(txtCambio.Text):C2}");
                    }

                    MessageBox.Show("Factura generada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVArticulos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DGVArticulos.SelectedRows)
                {
                    DGVArticulos.Rows.Remove(row);
                }
                ActualizarTotal();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Articulo(string codigo, string nombre, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }
    }
}