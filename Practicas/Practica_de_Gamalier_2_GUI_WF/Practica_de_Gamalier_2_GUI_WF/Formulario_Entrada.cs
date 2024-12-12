using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_de_Gamalier_2_GUI_WF
{
    public partial class Formulario_Entrada : Form
    {
        private Form1 formulario_Sistema;
        
        public Formulario_Entrada()
        {
            InitializeComponent();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formulario_Sistema == null)
            {
                formulario_Sistema = new Form1();
                formulario_Sistema.FormClosed += new FormClosedEventHandler(Cerrarformulario_Sistema);
                formulario_Sistema.WindowState = FormWindowState.Normal;
                formulario_Sistema.Show();
            }
            else
            {
                formulario_Sistema.WindowState = FormWindowState.Normal;
                formulario_Sistema.BringToFront();
                formulario_Sistema.Activate();
            }
        }

        void Cerrarformulario_Sistema (object sender, FormClosedEventArgs e)
        {
            formulario_Sistema = null;
        }
    }
}