using System.Security.Cryptography;

namespace Practica_de_Gamalier_2_GUI_WF
{
    public partial class Form1 : Form
    {
        private Proveedores proveedores;
        private Productos productos;
        public Form1()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proveedores == null)
            {
                proveedores = new Proveedores();
                proveedores.MdiParent = this;
                proveedores.FormClosed += new FormClosedEventHandler(CerrarProveedores);
                proveedores.WindowState = FormWindowState.Maximized;
                proveedores.Show();
            }
            else
            {
                proveedores.WindowState = FormWindowState.Maximized;
                proveedores.BringToFront();
                proveedores.Activate();
            }
        }

        void CerrarProveedores(object sender, FormClosedEventArgs e)
        {
            proveedores = null;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productos == null)
            {
                productos = new Productos();
                productos.MdiParent = this;
                productos.FormClosed += new FormClosedEventHandler(CerrarProductos);
                productos.WindowState = FormWindowState.Maximized;
                productos.Show();
            }
            else
            {
                productos.WindowState = FormWindowState.Maximized;
                productos.BringToFront();
                productos.Activate();
            }
        }

        void CerrarProductos(object sender, EventArgs e)
        {
            productos = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}