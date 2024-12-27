using System;
using System.Drawing;
using System.Windows.Forms;
namespace Ejercicio_4___Desafío_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCurso.Clear();
            txtSección.Clear();
            txtÁrea.Clear();
            txtPromedio.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtStatus.Clear();
            txtStatus.BackColor = SystemColors.Window;
            txtStatus.ForeColor = SystemColors.WindowText;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double n3 = Convert.ToDouble(txtN3.Text);
            double n4 = Convert.ToDouble(txtN4.Text);

            double promedio = (n1 + n2 + n3 + n4) / 4;

            txtPromedio.Text = promedio.ToString("F2");

            if (promedio >= 70)
            {
                txtStatus.Text = "Aprobado";
                txtStatus.BackColor = Color.Green;
                txtStatus.ForeColor = Color.White;
            }
            else
            {
                txtStatus.Text = "Reprobado";
                txtStatus.BackColor = Color.Red;
                txtStatus.ForeColor = Color.White;
            }

        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
