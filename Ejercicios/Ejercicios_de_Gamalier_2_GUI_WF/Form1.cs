namespace Ejercicios_de_Gamalier_2_GUI_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCargo.Text) || string.IsNullOrWhiteSpace(txtSueldo.Text) || string.IsNullOrWhiteSpace(txtHijos.Text))
            {
                MessageBox.Show("Debes completar todos los campos");
            } else
            {
                double sueldoNeto, sueldoBruto, afp, sfs;
                int descuento, incentivo, hijos = Convert.ToInt32(txtHijos.Text), ingresoAnual, isrAnual, isrMensual;
                incentivo = hijos * 500;

                sueldoBruto = Convert.ToDouble(txtSueldo.Text);
                string nombreEmpleado = txtNombre.Text;
                string Cargo = txtCargo.Text;
                double sumatoriaIncentivo = sueldoBruto + incentivo;
                int totalIncentivo = Convert.ToInt32(sumatoriaIncentivo);

                afp = sueldoBruto * 0.0287;
                sfs = sueldoBruto * 0.0304;

                descuento = Convert.ToInt32(afp + sfs);
                sueldoNeto = totalIncentivo - descuento;
                ingresoAnual = Convert.ToInt32(sueldoNeto * 12);

                if (ingresoAnual <= 416220)
                {
                    lbSueldoIncentivo.Text = $"Sueldo Bruto + Incentivo es: {totalIncentivo}";
                    lbAFP.Text = $"El AFP del empleado es de: {afp}";
                    lbSFS.Text = $"El SFS del empleado es de: {sfs}";
                    lbISR.Text = "No aplica a ISR";
                    lbSueldoNet.Text = $"El sueldo neto es: {sueldoNeto}";
                    lbTotalDescuento.Text = $"El descuento es: {descuento}";

                    txtHijos.Enabled = false;
                    txtCargo.Enabled = false;
                    txtNombre.Enabled = false;
                    txtSueldo.Enabled = false;
                }
                else if (ingresoAnual > 416220 && ingresoAnual < 624329)
                {
                    isrAnual = Convert.ToInt32(0.15 * (ingresoAnual - 416220));
                    isrMensual = isrAnual / 12;

                    lbSueldoIncentivo.Text = $"Sueldo Bruto + Incentivo es: {totalIncentivo}";
                    lbAFP.Text = $"El AFP del empleado es de: {afp}";
                    lbSFS.Text = $"El SFS del empleado es de: {sfs}";
                    lbISR.Text = $"El ISR del empleado es de: {isrMensual}";
                    lbSueldoNet.Text = $"El sueldo neto es: {sueldoNeto}";
                    lbTotalDescuento.Text = $"El descuento es: {descuento}";

                    txtHijos.Enabled = false;
                    txtCargo.Enabled = false;
                    txtNombre.Enabled = false;
                    txtSueldo.Enabled = false;
                }
                else if (ingresoAnual >= 624329 && ingresoAnual < 867123)
                {
                    isrAnual = Convert.ToInt32(0.2 * (ingresoAnual - 624329));
                    isrMensual = isrAnual / 12;

                    lbSueldoIncentivo.Text = $"Sueldo Bruto + Incentivo es: {totalIncentivo}";
                    lbAFP.Text = $"El AFP del empleado es de: {afp}";
                    lbSFS.Text = $"El SFS del empleado es de: {sfs}";
                    lbISR.Text = $"El ISR del empleado es de: {isrMensual}";
                    lbSueldoNet.Text = $"El sueldo neto es: {sueldoNeto}";
                    lbTotalDescuento.Text = $"El descuento es: {descuento}";

                    txtHijos.Enabled = false;
                    txtCargo.Enabled = false;
                    txtNombre.Enabled = false;
                    txtSueldo.Enabled = false;
                }
                else if (ingresoAnual >= 867123)
                {
                    isrAnual = Convert.ToInt32(0.25 * (ingresoAnual - 624329));
                    isrMensual = isrAnual / 12;

                    lbSueldoIncentivo.Text = $"Sueldo Bruto + Incentivo es: {totalIncentivo}";
                    lbAFP.Text = $"El AFP del empleado es de: {afp}";
                    lbSFS.Text = $"El SFS del empleado es de: {sfs}";
                    lbISR.Text = $"El ISR del empleado es de: {isrMensual}";
                    lbSueldoNet.Text = $"El sueldo neto es: {sueldoNeto}";
                    lbTotalDescuento.Text = $"El descuento es: {descuento}";

                    txtHijos.Enabled = false;
                    txtCargo.Enabled = false;
                    txtNombre.Enabled = false;
                    txtSueldo.Enabled = false;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHijos.Clear();
            txtCargo.Clear();
            txtNombre.Clear();
            txtSueldo.Clear();
            txtHijos.Enabled = true;
            txtCargo.Enabled = true;
            txtNombre.Enabled = true;
            txtSueldo.Enabled = true;

            lbSueldoNet.Text = "";
            lbSueldoIncentivo.Text = "";
            lbTotalDescuento.Text = "";
            lbSFS.Text = "";
            lbTotalDescuento.Text = "";
            lbAFP.Text = "";
            lbISR.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que quieres salir?",
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
