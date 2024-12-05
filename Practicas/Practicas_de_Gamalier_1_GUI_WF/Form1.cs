using System.Windows.Forms;

namespace Practicas_de_Gamalier_1_GUI_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text) || string.IsNullOrWhiteSpace(cbCargo.Text) || string.IsNullOrWhiteSpace(txtSueldo.Text) || string.IsNullOrWhiteSpace(txtHijos.Text))
                {
                    MessageBox.Show("Debes completar todos los campos");
                    return;
                }

                if (!double.TryParse(txtSueldo.Text, out double sueldoBruto) || !int.TryParse(txtHijos.Text, out int hijos))
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos validos en Sueldo e Hijos.");
                    return;
                }

                double sueldoNeto, afp, sfs;
                int descuento, incentivo = hijos * 500, isrMensual = 0, isrAnual = 0;
                string nombreEmpleado = txtNombreEmpleado.Text;
                string Cargo = cbCargo.Text;
                double totalIncentivo = sueldoBruto + incentivo;
                afp = sueldoBruto * 0.0287;
                sfs = sueldoBruto * 0.0304;
                double ingresoAnual = (totalIncentivo - (afp + sfs)) * 12;

                if (ingresoAnual <= 416220)
                {
                    lbISR.Text = "Exento";
                    descuento = Convert.ToInt32(afp + sfs);
                }
                else if (ingresoAnual <= 624329)
                {
                    isrAnual = Convert.ToInt32(0.15 * (ingresoAnual - 416220));
                }
                else if (ingresoAnual <= 867123)
                {
                    isrAnual = Convert.ToInt32(0.2 * (ingresoAnual - 624329));
                }
                else
                {
                    isrAnual = Convert.ToInt32(0.25 * (ingresoAnual - 624329));
                }

                if (isrAnual > 0)
                {
                    isrMensual = isrAnual / 12;
                    descuento = Convert.ToInt32(afp + sfs + isrMensual);
                }
                else
                {
                    descuento = Convert.ToInt32(afp + sfs);
                }

                sueldoNeto = totalIncentivo - descuento;

                lbSueldoBonificacion.Text = $"Sueldo + Bonificacion: {totalIncentivo:F2}";
                lbAFP.Text = $"AFP: {afp:F2}";
                lbSFS.Text = $"SFS: {sfs:F2}";
                lbISR.Text = $"ISR: {(isrMensual > 0 ? isrMensual.ToString("F2") : "Exento")}";
                lbOtros.Text = $"Otros: {incentivo}";
                lbSueldoNeto.Text = $"Sueldo Neto: {sueldoNeto:F2}";
                lbTotalDescuento.Text = $"Total Descuento: {descuento}";

                dgvDatos.Rows.Add(
                    nombreEmpleado,
                    Cargo,
                    sueldoBruto,
                    hijos,
                    totalIncentivo,
                    afp,
                    sfs,
                    isrMensual > 0 ? $"{isrMensual:F2}" : "Exento",
                    incentivo,
                    descuento,
                    sueldoNeto
                );

                MessageBox.Show("Registros guardados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text) || string.IsNullOrWhiteSpace(cbCargo.Text) || string.IsNullOrWhiteSpace(txtSueldo.Text) || string.IsNullOrWhiteSpace(txtHijos.Text))
                {
                    MessageBox.Show("Debes completar todos los campos");
                }
                else
                {
                    if (dgvDatos.CurrentRow != null)
                    {
                        if (dgvDatos.CurrentRow != null && dgvDatos.CurrentRow.Index >= 0)
                        {
                            if (!double.TryParse(txtSueldo.Text, out double sueldoBruto) || !int.TryParse(txtHijos.Text, out int hijos))
                            {
                                MessageBox.Show("Por favor, ingrese valores numericos validos en Sueldo e Hijos.");
                                return;
                            }

                            double sueldoNeto, afp, sfs;
                            int descuento, incentivo = hijos * 500, isrMensual = 0, isrAnual = 0;
                            string nombreEmpleado = txtNombreEmpleado.Text;
                            string Cargo = cbCargo.Text;
                            double totalIncentivo = sueldoBruto + incentivo;
                            afp = sueldoBruto * 0.0287;
                            sfs = sueldoBruto * 0.0304;
                            double ingresoAnual = (totalIncentivo - (afp + sfs)) * 12;

                            if (ingresoAnual <= 416220)
                            {
                                isrMensual = 0;
                                descuento = Convert.ToInt32(afp + sfs);
                            }
                            else if (ingresoAnual <= 624329)
                            {
                                isrAnual = Convert.ToInt32(0.15 * (ingresoAnual - 416220));
                            }
                            else if (ingresoAnual <= 867123)
                            {
                                isrAnual = Convert.ToInt32(0.2 * (ingresoAnual - 624329));
                            }
                            else
                            {
                                isrAnual = Convert.ToInt32(0.25 * (ingresoAnual - 624329));
                            }

                            if (isrAnual > 0)
                            {
                                isrMensual = isrAnual / 12;
                                descuento = Convert.ToInt32(afp + sfs + isrMensual);
                            }
                            else
                            {
                                descuento = Convert.ToInt32(afp + sfs);
                            }

                            sueldoNeto = totalIncentivo - descuento;

                            DataGridViewRow row = dgvDatos.CurrentRow;
                            row.Cells[0].Value = nombreEmpleado;
                            row.Cells[1].Value = Cargo;
                            row.Cells[2].Value = sueldoBruto;
                            row.Cells[3].Value = hijos;
                            row.Cells[4].Value = totalIncentivo;
                            row.Cells[5].Value = afp;
                            row.Cells[6].Value = sfs;
                            row.Cells[7].Value = isrMensual > 0 ? $"{isrMensual:F2}" : "Exento";
                            row.Cells[8].Value = incentivo;
                            row.Cells[9].Value = descuento;
                            row.Cells[10].Value = sueldoNeto;

                            MessageBox.Show("Registro modificando exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una fila para modificar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que limpiar todo?",
                                                         "Confirmar limpieza",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                txtNombreEmpleado.Clear();
                cbCargo.SelectedIndex = -1;
                txtHijos.Clear();
                txtSueldo.Clear();
                lbSueldoBonificacion.Text = "Sueldo + Bonificacion:";
                lbAFP.Text = "AFP:";
                lbSFS.Text = "SFS:";
                lbISR.Text = "ISR:";
                lbOtros.Text = "Otros:";
                lbTotalDescuento.Text = "Total Descuento:";
                lbSueldoNeto.Text = "Sueldo Neto:";
                MessageBox.Show("Limpieza exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Limpieza cancelada");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGeneraArchivo_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para generar una factura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string ruta = @"C:\Users\HP\Desktop\Archivo.txt";

                using (StreamWriter archivo_txt = new StreamWriter(ruta))
                {
                    archivo_txt.WriteLine(
                        "{0,-15}{1,-15}{2,-10}{3,-10}{4,-15}{5,-10}{6,-10}{7,-10}{8,-15}{9,-10}",
                        "Nombre", "Cargo", "Sueldo", "Hijos", "Incentivo", "AFP", "SFS", "ISR", "Descuento", "Neto");
                    archivo_txt.WriteLine(new string('=', 120));

                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        if (row.IsNewRow) continue;

                        archivo_txt.WriteLine(
                            "{0,-15}{1,-15}{2,-10:F2}{3,-10}{4,-15:F2}{5,-10:F2}{6,-10:F2}{7,-10}{8,-15:F2}{9,-10:F2}",
                            row.Cells[0].Value,
                            row.Cells[1].Value,
                            Convert.ToDouble(row.Cells[2].Value),
                            Convert.ToInt32(row.Cells[3].Value),
                            Convert.ToDouble(row.Cells[4].Value),
                            Convert.ToDouble(row.Cells[5].Value),
                            Convert.ToDouble(row.Cells[6].Value),
                            row.Cells[7].Value,
                            Convert.ToDouble(row.Cells[9].Value),
                            Convert.ToDouble(row.Cells[10].Value)
                        );
                    }
                }

                MessageBox.Show($"Nomina generada correctamente: {ruta}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al generar el archivo de la nomina: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro de que deseas eliminar este registro?",
                                                         "Confirmar eliminacion",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int filaSeleccionada = dgvDatos.SelectedRows[0].Index;
                    dgvDatos.Rows.RemoveAt(filaSeleccionada);

                    MessageBox.Show("Registro eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDatos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDatos.Rows[e.RowIndex];

                txtNombreEmpleado.Text = row.Cells[0].Value?.ToString();
                cbCargo.Text = row.Cells[1].Value?.ToString();
                txtSueldo.Text = row.Cells[2].Value?.ToString();
                txtHijos.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void btnClearDatos_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas limpiar la tabla?", "Confirma limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                dgvDatos.Rows.Clear();
                MessageBox.Show("Limpieza exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Limpieza cancelada");
            }
        }
    }
}