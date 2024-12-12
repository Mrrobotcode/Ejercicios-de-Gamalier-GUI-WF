using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Practica_de_Gamalier_2_GUI_WF
{
    public partial class Productos : Form
    {
        static int ID = 0;
        public Productos()
        {
            InitializeComponent();
        }

        private void btnLimpiarCamposProducto_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Deseas limpiar todos los campos?", "Confirma limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                txtNombreProducto.Clear();
                txtCategoriaProducto.Clear();
                txtPrecioProducto.Clear();
                txtStockProducto.Clear();
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtCategoriaProducto.Text) || string.IsNullOrWhiteSpace(txtPrecioProducto.Text) || string.IsNullOrWhiteSpace(txtStockProducto.Text) || !int.TryParse(txtPrecioProducto.Text, out int precioProducto))
            {
                MessageBox.Show("Debes completar todos los campos o debes ingresa un valor numerico en el campo: Precio");
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Deseas agregar los datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    ID++;
                    dgvListaProductos.Rows.Add
                    (
                        ID.ToString(),
                        txtNombreProducto.Text,
                        txtCategoriaProducto.Text,
                        precioProducto,
                        txtStockProducto.Text
                    );
                }
            }
        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tcReportesProductos_Click(object sender, EventArgs e)
        {
            tcReportesProductos.Size = new Size(1000, 1000);
            lbOpcionesFormProductos.ForeColor = Color.White;
            lbOpcionesFormProductos.BackColor = Color.White;
            lbOpcionesFormProductos.Visible = false;

            btnModificarProductos.ForeColor = Color.White;
            btnModificarProductos.BackColor = Color.White;
            btnModificarProductos.Visible = false;

            btnMostraListaProductos.ForeColor = Color.White;
            btnMostraListaProductos.BackColor = Color.White;
            btnMostraListaProductos.Visible = false;
        }

        private void btnSalirListaProductos_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                tcReportesProductos.Size = new Size(134, 26);

                btnModificarProductos.ForeColor = Color.Black;
                btnModificarProductos.BackColor = DefaultBackColor;
                btnModificarProductos.Visible = true;

                lbOpcionesFormProductos.ForeColor = Color.White;
                lbOpcionesFormProductos.BackColor = Color.Black;
                lbOpcionesFormProductos.Visible = true;

                btnMostraListaProductos.ForeColor = Color.Black;
                btnMostraListaProductos.BackColor = DefaultBackColor;
                btnMostraListaProductos.Visible = true;
            }
        }

        private void btnEliminarListaProductos_Click(object sender, EventArgs e)
        {
            if (dgvListaProductos.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres eliminar estos datos?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int filaSeleccionada = dgvListaProductos.SelectedRows[0].Index;
                    dgvListaProductos.Rows.RemoveAt(filaSeleccionada);

                    MessageBox.Show("Datos eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiarListaProductos_Click(object sender, EventArgs e)
        {
            if (dgvListaProductos.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres limpiar la lista?", "Confirmar limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    dgvListaProductos.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("No se puede limpiar la lista, no hay datos en ella");
            }
        }

        private void dgvListaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListaProductos.Rows[e.RowIndex];

                txtNombreProducto.Text = row.Cells[1].Value?.ToString();
                txtCategoriaProducto.Text = row.Cells[2].Value?.ToString();
                txtPrecioProducto.Text = row.Cells[3].Value?.ToString();
                txtStockProducto.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void btnModificarProductos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtCategoriaProducto.Text) || string.IsNullOrWhiteSpace(txtPrecioProducto.Text) || string.IsNullOrWhiteSpace(txtStockProducto.Text) || !int.TryParse(txtPrecioProducto.Text, out int precioProducto))
            {
                MessageBox.Show("Debes completar todos los campos o debes ingresa un valor numerico en el campo: Precio");
                return;
            }
            else
            {
                if (dgvListaProductos.CurrentRow != null)
                {
                    if (dgvListaProductos.CurrentRow != null && dgvListaProductos.CurrentRow.Index >= 0)
                    {
                        DialogResult resultado = MessageBox.Show("¿Seguro que quieres modificar estos datos?", "Confirmar modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (resultado == DialogResult.Yes)
                        {
                            DataGridViewRow row = dgvListaProductos.CurrentRow;
                            row.Cells[1].Value = txtNombreProducto.Text;
                            row.Cells[2].Value = txtCategoriaProducto.Text;
                            row.Cells[3].Value = precioProducto;
                            row.Cells[4].Value = txtStockProducto.Text;

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

        private void btnBuscarProductoLista_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProductoLista.Text))
            {
                MessageBox.Show("Debes completar este campo");
                return;
            }
            else
            {
                if (dgvListaProductos.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow))
                {
                    DataGridViewRow row = dgvListaProductos.CurrentRow;
                    if (txtBuscarProductoLista.Text == row.Cells[0].Value.ToString())
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

        private void btnMostraListaProductos_Click(object sender, EventArgs e)
        {
            tcReportesProductos.Size = new Size(1000, 1000);
            lbOpcionesFormProductos.ForeColor = Color.White;
            lbOpcionesFormProductos.BackColor = Color.White;
            lbOpcionesFormProductos.Visible = false;

            btnModificarProductos.ForeColor = Color.White;
            btnModificarProductos.BackColor = Color.White;
            btnModificarProductos.Visible = false;

            btnMostraListaProductos.ForeColor = Color.White;
            btnMostraListaProductos.BackColor = Color.White;
            btnMostraListaProductos.Visible = false;
        }
    }
}