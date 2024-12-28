using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = DGV.SelectedRows[0].Index;
            clientes.RemoveAt(index);
            ActualizarDataGridView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ActualizarDataGridView()
        {
            DGV.DataSource = null;
            DGV.DataSource = clientes;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtSueldo.Clear();
            txtNhijos.Clear();
            txtOtros.Clear();
            txtAFP.Clear();
            txtISR.Clear();
            txtSFS.Clear();
            txtTotalDescuento.Clear();
            txtSueldoNeto.Clear();
            txtTotalsueldoMásIngresos.Clear();
            
        }

        private decimal CalcularISR(decimal sueldo)
        {

            if (sueldo <= 34685)
                return 0;
            else if (sueldo <= 52027)
                return (sueldo - 34685) * 0.15m;
            else
                return (sueldo - 52027) * 0.25m + 2601;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(cmbCargo.Text) ||
                !decimal.TryParse(txtSueldo.Text, out decimal sueldo) ||
                !int.TryParse(txtNhijos.Text, out int hijos))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal ingresoHijos = hijos * 1000;
            decimal afp = sueldo * 0.0287m;
            decimal sfs = sueldo * 0.0304m;
            decimal isr = CalcularISR(sueldo);
            decimal otros = 1m;
            decimal totalDescuento = afp + sfs + isr + otros;
            decimal sueldoNeto = (sueldo + ingresoHijos) - totalDescuento;
            decimal sueldoMasIngreso = sueldo + ingresoHijos;

            Cliente cliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Cargo = cmbCargo.Text,
                Sueldo = sueldo,
                NumeroHijos = hijos,
                IngresosPorHijos = ingresoHijos,
                AFP = afp,
                SFS = sfs,
                ISR = isr,
                Otros = otros,
                TotalDescuento = totalDescuento,
                SueldoNeto = sueldoNeto
            };

            clientes.Add(cliente);
            ActualizarDataGridView();
            LimpiarFormulario();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSueldo.Text) || !decimal.TryParse(txtSueldo.Text, out decimal sueldo) ||
                !int.TryParse(txtNhijos.Text, out int hijos))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal ingresoHijos = hijos * 1000;
            decimal afp = sueldo * 0.0287m;
            decimal sfs = sueldo * 0.0304m;
            decimal isr = CalcularISR(sueldo);
            decimal otros = 1m;
            decimal totalDescuento = afp + sfs + isr + otros;
            decimal sueldoNeto = (sueldo + ingresoHijos) - totalDescuento;
            decimal sueldoMasIngreso = sueldo + ingresoHijos;

            txtAFP.Text = afp.ToString("F2");
            txtSFS.Text = sfs.ToString("F2");
            txtISR.Text = isr.ToString("F2");
            txtTotalDescuento.Text = totalDescuento.ToString("F2");
            txtSueldoNeto.Text = sueldoNeto.ToString("F2");
            txtTotalsueldoMásIngresos.Text = sueldoMasIngreso.ToString("F2");
            txtOtros.Text = otros.ToString("F2");
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = DGV.SelectedRows[0].Index;
            Cliente cliente = clientes[index];

            txtNombre.Text = cliente.Nombre;
            cmbCargo.Text = cliente.Cargo;
            txtSueldo.Text = cliente.Sueldo.ToString();
            txtNhijos.Text = cliente.NumeroHijos.ToString();
            txtOtros.Text = cliente.Otros.ToString();

            clientes.RemoveAt(index);
            ActualizarDataGridView();
        }

        private void txtTotalsueldoMásIngresos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOtros_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

    public class Cliente
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public decimal Sueldo { get; set; }
        public int NumeroHijos { get; set; }
        public decimal IngresosPorHijos { get; set; }
        public decimal AFP { get; set; }
        public decimal SFS { get; set; }
        public decimal ISR { get; set; }
        public decimal Otros { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal SueldoNeto { get; set; }
    }