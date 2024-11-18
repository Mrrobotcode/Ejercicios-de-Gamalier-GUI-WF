namespace Ejercicios_de_Gamalier_1_GUI_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);
            double resultado = valor1 + valor2;
            double resta = valor1 - valor2;
            double multi = valor1 * valor2;
            double div = valor1 / valor2;

            txtResultado.Text = resultado.ToString();
            txtResta.Text = resta.ToString();
            txtMulti.Text = multi.ToString();
            txtDi.Text = div.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtResultado.Clear();
            txtResta.Clear();
            txtMulti.Clear();
            txtDi.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResultado.Enabled = false;
            txtResta.Enabled = false;
            txtMulti.Enabled = false;
            txtDi.Enabled = false;
        }
    }
}
