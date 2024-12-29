using System;
using System.Windows.Forms;

namespace Prueba_Técnica_MDI_Heather_Cobas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedor formProveedor = new FormProveedor();
            formProveedor.MdiParent = this;
            formProveedor.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto formProducto = new FormProducto();
            formProducto.MdiParent = this;
            formProducto.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
