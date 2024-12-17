using System;
using System.Windows.Forms;

namespace Ejercicio_1___Desafío_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private void btnRestar_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(this.N1.Text);
            int N2 = int.Parse(this.N2.Text);
            int Resta = N1 - N2;
            Res.Text = " " + Resta.ToString();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(this.N1.Text);
            int N2 = int.Parse(this.N2.Text);
            int suma = N1 + N2;
            Res.Text = " " + suma.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(this.N1.Text);
            int N2 = int.Parse(this.N2.Text);
            int Multi = N1 * N2;
            Res.Text = " " + Multi.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double N1 = int.Parse(this.N1.Text);
            double N2 = int.Parse(this.N2.Text);
            double Divi = N1 / N2;
            Res.Text = " " + Divi.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            N1.Clear();
            Res.Clear();
            N2.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
