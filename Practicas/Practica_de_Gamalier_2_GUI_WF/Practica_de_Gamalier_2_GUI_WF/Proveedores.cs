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
    public partial class Proveedores : Form
    {
        static int ID = 0;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnLimpiarCamposProveedores_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres limpiar todos los campos?", "Confirma limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                txtNombreProveedor.Clear();
                txtCorreo.Clear();
                cbCuidad.SelectedIndex = -1;
                txtDireccion.Clear();
                txtRNC.Clear();
                txtTelefono.Clear();
            }
        }

        private void btnAgregarProveedores_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(cbCuidad.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtRNC.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            else
            {
                if (txtCorreo.Text.Contains("@gmail.com") || txtCorreo.Text.Contains("@GMAIL.COM"))
                {
                    DialogResult resultado = MessageBox.Show("Deseas agregar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        ID++;
                        dgvListaProveedores.Rows.Add
                        (
                            ID.ToString(),
                            txtNombreProveedor.Text,
                            txtRNC.Text,
                            txtDireccion.Text,
                            txtTelefono.Text,
                            txtCorreo.Text,
                            cbCuidad.Text
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Debe contener correo electronico");
                    return;
                }
            }
        }

        private void btnSalirProveedores_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(1000, 1000);
            btnModificarProveedores.BackColor = Color.White;
            btnModificarProveedores.ForeColor = Color.White;
            btnModificarProveedores.Visible = false;

            btnMostraListaProveedores.BackColor = Color.White;
            btnMostraListaProveedores.ForeColor = Color.White;
            btnMostraListaProveedores.Visible = false;
        }

        private void btnLimpiarListaProveedores_Click(object sender, EventArgs e)
        {
            if (dgvListaProveedores.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres limpiar la lista?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    dgvListaProveedores.Rows.Clear();
                }
            } else
            {
                MessageBox.Show("No se puede limpiar la lista, no hay datos en ella");
            }
        }

        private void btnEliminarListaProveedores_Click(object sender, EventArgs e)
        {
            if (dgvListaProveedores.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres eliminar estos datos?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int filaSeleccionada = dgvListaProveedores.SelectedRows[0].Index;
                    dgvListaProveedores.Rows.RemoveAt(filaSeleccionada);

                    MessageBox.Show("Datos eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalirListaProveedores_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                tabControl1.Size = new Size(137, 24);
                btnModificarProveedores.BackColor = DefaultBackColor;
                btnModificarProveedores.ForeColor = Color.Black;
                btnModificarProveedores.Visible = true;

                btnMostraListaProveedores.BackColor = DefaultBackColor;
                btnMostraListaProveedores.ForeColor = Color.Black;
                btnMostraListaProveedores.Visible = true;
            }
        }

        private void dgvListaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListaProveedores.Rows[e.RowIndex];
                txtNombreProveedor.Text = row.Cells[1].Value?.ToString();
                txtRNC.Text = row.Cells[2].Value?.ToString();
                txtDireccion.Text = row.Cells[3].Value?.ToString();
                txtTelefono.Text = row.Cells[4].Value?.ToString();
                txtCorreo.Text = row.Cells[5].Value?.ToString();
                cbCuidad.Text = row.Cells[6].Value?.ToString();
            }
        }

        private void btnModificarProveedores_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProveedor.Text) || string.IsNullOrWhiteSpace(txtRNC.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(cbCuidad.Text))
            {
                MessageBox.Show("Debes completar todos los campos o debes ingresa un valor numerico en el campo: Precio");
                return;
            }
            else
            {
                if (dgvListaProveedores.CurrentRow != null)
                {
                    if (dgvListaProveedores.CurrentRow != null && dgvListaProveedores.CurrentRow.Index >= 0)
                    {
                        DialogResult resultado = MessageBox.Show("¿Seguro que quieres modificar estos datos?", "Confirmar modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (resultado == DialogResult.Yes)
                        {
                            DataGridViewRow row = dgvListaProveedores.CurrentRow;
                            row.Cells[1].Value = txtNombreProveedor.Text;
                            row.Cells[2].Value = txtRNC.Text;
                            row.Cells[3].Value = txtDireccion.Text;
                            row.Cells[4].Value = txtTelefono.Text;
                            row.Cells[5].Value = txtCorreo.Text;
                            row.Cells[6].Value = cbCuidad.Text;

                            MessageBox.Show("Datos modificando exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fila para modificar");
                    }
                }
            }
        }

        private void btnBuscarProveedorLista_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProveedor.Text))
            {
                MessageBox.Show("Debes completar este campo");
                return;
            }
            else
            {
                if (dgvListaProveedores.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow))
                {
                    DataGridViewRow row = dgvListaProveedores.CurrentRow;
                    if (txtBuscarProveedor.Text == row.Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Se encontro este proveedor");
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el proveedor");
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para hacer la busqueda");
                }
            }
        }

        private void btnMostraListaProveedores_Click(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(1000, 1000);
            btnMostraListaProveedores.BackColor = Color.White;
            btnMostraListaProveedores.ForeColor = Color.White;
            btnMostraListaProveedores.Visible = false;

            btnModificarProveedores.BackColor = Color.White;
            btnModificarProveedores.ForeColor = Color.White;
            btnModificarProveedores.Visible = false;
        }
    }
}