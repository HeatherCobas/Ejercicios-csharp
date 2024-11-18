using System;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void label3_Click(object sender, EventArgs e){}

        private void label7_Click(object sender, EventArgs e){}

        private void label11_Click(object sender, EventArgs e){}

        private void label13_Click(object sender, EventArgs e){}

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {

                string nombre = txtNombre.Text;
                string cargo = txtCargo.Text;
                decimal sueldo = decimal.Parse(txtSueldo.Text);
                int hijos = int.Parse(txtHijos.Text);

                decimal incentivo = hijos * 500;

                decimal totalSalario = sueldo + incentivo;

                decimal afp = totalSalario * 0.0287m;
                decimal sfs = totalSalario * 0.0304m;
                decimal irs = totalSalario > 34685 ? (totalSalario - 34685) * 0.15m : 0;
                decimal otros = 0;

                decimal totalDescuentos = afp + sfs + irs + otros;

                decimal sueldoNeto = totalSalario - totalDescuentos;

                txtTotalSalario.Text = totalSalario.ToString("C");
                txtAFP.Text = afp.ToString("C");
                txtSFS.Text = sfs.ToString("C");
                txtIRS.Text = irs.ToString("C");
                txtOtros.Text = otros.ToString("C");
                txtTotalDescuentos.Text = totalDescuentos.ToString("C");
                txtSueldoNeto.Text = sueldoNeto.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCargo.Text = "";
            txtSueldo.Text = "";
            txtHijos.Text = "";
            txtTotalSalario.Text = "";
            txtAFP.Text = "";
            txtSFS.Text = "";
            txtIRS.Text = "";
            txtOtros.Text = "";
            txtTotalDescuentos.Text = "";
            txtSueldoNeto.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
