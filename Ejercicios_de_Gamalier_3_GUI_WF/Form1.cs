using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicios_de_Gamalier_3_GUI_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CambiarColorProgressBar(int calificacion)
        {
            CustomProgressBar pbStatus = new CustomProgressBar();

            pbStatus.Minimum = 0;
            pbStatus.Maximum = 100;
            pbStatus.Value = Math.Min(Math.Max(calificacion, pbStatus.Minimum), pbStatus.Maximum);
            pbStatus.Location = new Point(12, 388);
            pbStatus.Width = 200;
            pbStatus.Height = 30;

            if (calificacion >= 70)
            {
                pbStatus.ProgressBarColor = Color.Green;
            }
            else
            {
                pbStatus.ProgressBarColor = Color.Red;
            }

            foreach (var control in this.Controls)
            {
                if (control is CustomProgressBar)
                {
                    this.Controls.Remove((Control)control);
                }
            }

            this.Controls.Add(pbStatus);
        }

        public class CustomProgressBar : ProgressBar
        {
            public Color ProgressBarColor { get; set; }

            public CustomProgressBar()
            {
                this.SetStyle(ControlStyles.UserPaint, true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Rectangle rect = this.ClientRectangle;
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.LightGray, rect);
                rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
                using (Brush brush = new SolidBrush(ProgressBarColor))
                {
                    g.FillRectangle(brush, rect);
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtP1.Text) || string.IsNullOrWhiteSpace(txtP2.Text) || string.IsNullOrWhiteSpace(txtP3.Text) || string.IsNullOrWhiteSpace(txtP4.Text) || string.IsNullOrWhiteSpace(cbArea.Text) || string.IsNullOrWhiteSpace(cbCurso.Text) || string.IsNullOrWhiteSpace(cbSeccion.Text) || (!rbFemenino.Checked && !rbMasculino.Checked))
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }

            try
            {
                string nombre = txtNombre.Text;
                int p1 = Convert.ToInt32(txtP1.Text),
                    p2 = Convert.ToInt32(txtP2.Text),
                    p3 = Convert.ToInt32(txtP3.Text),
                    p4 = Convert.ToInt32(txtP4.Text);

                int calificacion = (p1 + p2 + p3 + p4) / 4;
                CambiarColorProgressBar(calificacion);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos para las calificaciones.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas limpiar todos los campos?",
                                                     "Confirmar limpieza",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                txtNombre.Clear();
                txtP1.Clear();
                txtP2.Clear();
                txtP3.Clear();
                txtP4.Clear();
                cbArea.SelectedIndex = -1;
                cbCurso.SelectedIndex = -1;
                cbSeccion.SelectedIndex = -1;
                rbFemenino.Checked = false;
                rbMasculino.Checked = false;

                foreach (var control in this.Controls)
                {
                    if (control is CustomProgressBar)
                    {
                        this.Controls.Remove((Control)control);
                        break;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?",
                                                     "Confirmar salida",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}