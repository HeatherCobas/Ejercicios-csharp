using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> respuestasCorrectas = new Dictionary<string, string>
        {
            { "Rojo", "Amor" },
            { "Amarillo", "Compañerismo" },
            { "Rosado", "Solidaridad" },
            { "Blanco", "Paz" },
            { "Verde", "Tolerancia" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            ValidarRespuesta(txbVerde, "Verde");
        }

        private void btnBlanco_Click(object sender, EventArgs e)
        {
            ValidarRespuesta(txbBlanco, "Blanco");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ValidarRespuesta(txbRosado, "Rosado");
        }

        private void txbRojo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbAmarillo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbBlanco_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarRespuesta(txbRojo, "Rojo");
        }

        private void btnAmarillo_Click(object sender, EventArgs e)
        {
            ValidarRespuesta(txbAmarillo, "Amarillo");
        }

        private void ValidarRespuesta(TextBox textBox, string color)
        {
            string respuestaUsuario = textBox.Text.Trim().ToLower();
            string respuestaCorrecta = respuestasCorrectas[color].ToLower();

            if (respuestaUsuario == respuestaCorrecta)
            {
                textBox.BackColor = Color.LightGreen;
            }
            else
            {
                textBox.BackColor = Color.LightCoral;
                MessageBox.Show($"La respuesta correcta para {color} es: {respuestasCorrectas[color]}",
                    "Respuesta Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

