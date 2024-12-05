using System.Diagnostics;

namespace Ejercicios_de_Gamalier_4_GUI_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreCliente.Text) || cbTipoHabitacion.SelectedIndex < 0 || cbPrecio.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvDatos.Rows.Add
                (
                    txtNombreCliente.Text,
                    cbTipoHabitacion.Text,
                    cbPrecio.Text,
                    dtpDesde.Text,
                    dtpHasta.Text
                );
                MessageBox.Show("Registro guardado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

                    MessageBox.Show("Registro eliminado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Clear();
            cbPrecio.Text = "";
            cbTipoHabitacion.Text = "";
            dgvDatos.Rows.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoHabitacion.SelectedIndex == -1 || cbTipoHabitacion.SelectedIndex < 0)
            {
                MessageBox.Show("Ningun tipo de habitacion seleccionada");
            }
            else
            {
                switch (cbTipoHabitacion.SelectedIndex)
                {
                    case 0:
                        cbPrecio.SelectedIndex = 0;
                        break;

                    case 1:
                        cbPrecio.SelectedIndex = 1;
                        break;

                    case 2:
                        cbPrecio.SelectedIndex = 2;
                        break;

                    case 3:
                        cbPrecio.SelectedIndex = 3;
                        break;
                }
            }
        }
    }
}
