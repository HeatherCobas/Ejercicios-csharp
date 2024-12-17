using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaReservas
{
    public partial class FormReserva : Form
    {
        private List<Reserva> reservas = new List<Reserva>();
        private Dictionary<string, decimal> preciosHabitacion = new Dictionary<string, decimal>();

        public FormReserva()
        {
            InitializeComponent();

            preciosHabitacion.Add("Habitación Simple", 15000m);
            preciosHabitacion.Add("Habitación Doble", 20000m);
            preciosHabitacion.Add("Suite", 30000m);
        }

        private void FormReserva_Load(object sender, EventArgs e)
        {
            comboBoxTipoHabitacion.Items.AddRange(new string[] { "Habitación Simple", "Habitación Doble", "Suite" });
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cliente = txtCliente.Text;
                string tipoHabitacion = comboBoxTipoHabitacion.SelectedItem?.ToString();
                DateTime desde = dateTimePicker1.Value;
                DateTime hasta = dateTimePicker2.Value;

                if (string.IsNullOrWhiteSpace(cliente))
                {
                    MessageBox.Show("Por favor, ingrese el nombre del cliente.");
                    return;
                }

                if (string.IsNullOrEmpty(tipoHabitacion))
                {
                    MessageBox.Show("Por favor, seleccione un tipo de habitación.");
                    return;
                }

                if (desde > hasta)
                {
                    MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.");
                    return;
                }

                if (!preciosHabitacion.TryGetValue(tipoHabitacion, out decimal precio))
                {
                    MessageBox.Show("No se encontró el precio para el tipo de habitación seleccionado.");
                    return;
                }

                txtPrecio.Text = precio.ToString("F2");

                Reserva nuevaReserva = new Reserva
                {
                    Cliente = cliente,
                    TipoHabitacion = tipoHabitacion,
                    FDesde = desde,
                    FHasta = hasta,
                    Precio = precio
                };

                reservas.Add(nuevaReserva);
                listBox1.Items.Add(nuevaReserva.ToString());

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int indice = listBox1.SelectedIndex;
                reservas.RemoveAt(indice);
                listBox1.Items.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Seleccione una reserva para eliminar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtCliente.Clear();
            txtPrecio.Clear();
            comboBoxTipoHabitacion.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void comboBoxTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoHabitacion = comboBoxTipoHabitacion.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(tipoHabitacion) && preciosHabitacion.TryGetValue(tipoHabitacion, out decimal precio))
            {
                txtPrecio.Text = precio.ToString("F2");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public class Reserva
        {
            public string Cliente { get; set; }
            public DateTime FDesde { get; set; }
            public DateTime FHasta { get; set; }
            public string TipoHabitacion { get; set; }
            public decimal Precio { get; set; }

            public override string ToString()
            {
                return $"{Cliente} - {TipoHabitacion} - {FDesde.ToShortDateString()} a {FHasta.ToShortDateString()} - ${Precio:F2}";
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int indice = listBox1.SelectedIndex;
                reservas.RemoveAt(indice);
                listBox1.Items.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Seleccione una reserva para eliminar.");
            }
        }
    }
}

