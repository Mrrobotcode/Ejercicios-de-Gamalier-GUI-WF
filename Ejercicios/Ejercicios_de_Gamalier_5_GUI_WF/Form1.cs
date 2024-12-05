using System.Data;

namespace Ejercicios_de_Gamalier_5_GUI_WF
{
    public partial class Form1 : Form
    {
        static int articulo1_precio = 600, articulo2_precio = 1000, articulo3_precio = 5000;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbArticulos.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor, selecciona un artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtEfectivo.Text, out int efectivo) || !int.TryParse(txtCantidadArticulo.Text, out int cantidad))
                {
                    MessageBox.Show("Ingresa valores válidos para efectivo y cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int precio = 0;
                string idArticulo = "";
                switch (cbArticulos.SelectedIndex)
                {
                    case 0:
                        idArticulo = "1";
                        precio = articulo1_precio;
                        break;
                    case 1:
                        idArticulo = "2";
                        precio = articulo2_precio;
                        break;
                    case 2:
                        idArticulo = "3";
                        precio = articulo3_precio;
                        break;
                }

                int subtotal = cantidad * precio;
                int cambio = efectivo - subtotal;

                if (cambio < 0)
                {
                    MessageBox.Show("El efectivo no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvTabla.Rows.Add
                (
                    idArticulo,
                    cbArticulos.Text,
                    precio,
                    cantidad,
                    efectivo,
                    cambio,
                    subtotal
                );

                MessageBox.Show("Registro guardado exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTabla.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para generar una factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string rutaArchivo = @"C:\Users\HP\Desktop\Factura.txt";
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    sw.WriteLine(" =========================================");
                    sw.WriteLine("                FACTURA                   ");
                    sw.WriteLine("==========================================");
                    sw.WriteLine($"Fecha: {DateTime.Now}");
                    sw.WriteLine();
                    sw.WriteLine("ID | Artículo | Precio | Cant. | Subtotal | Efectivo | Cambio");
                    sw.WriteLine("---------------------------------------------------------------");

                    
                    foreach (DataGridViewRow fila in dgvTabla.Rows)
                    {
                        if (fila.IsNewRow) continue;
                        string id = fila.Cells[0].Value?.ToString() ?? "";
                        string articulo = fila.Cells[1].Value?.ToString() ?? "";
                        string precio = fila.Cells[2].Value?.ToString() ?? "";
                        string cantidad = fila.Cells[3].Value?.ToString() ?? "";
                        string subtotal = fila.Cells[6].Value?.ToString() ?? "";
                        string efectivo = fila.Cells[4].Value?.ToString() ?? "";
                        string cambio = fila.Cells[5].Value?.ToString() ?? "";

                        sw.WriteLine($"{id,-5} | {articulo,-13} | {precio,6} | {cantidad,5} | {subtotal,8} | {efectivo,8} | {cambio,6}");
                    }

                    sw.WriteLine("=========================================");
                    sw.WriteLine("         ¡Gracias por su compra!         ");
                    sw.WriteLine("=========================================");
                }

                MessageBox.Show($"Factura generada correctamente: {rutaArchivo}", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvTabla.Rows.Clear();
            txtCantidadArticulo.Clear();
            txtEfectivo.Clear();
            cbArticulos.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbArticulos.Items.Add("Iphone X");
            cbArticulos.Items.Add("Iphone 14 PRO MAX");
            cbArticulos.Items.Add("Iphone 16 PRO MAX");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTabla.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int filaSeleccionada = dgvTabla.SelectedRows[0].Index;
                    dgvTabla.Rows.RemoveAt(filaSeleccionada);

                    MessageBox.Show("Registro eliminado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMostrarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog datos = new OpenFileDialog()
            {
                Title = "Selecciona tu archivo",
                Filter = "Selecciona archivos .txt: |*.txt",
                ShowHelp = true,
                InitialDirectory = @"C:\Users\HP\Desktop"
            };

            datos.HelpRequest += (sender, e) =>
            {
                MessageBox.Show("Selecciona tu archivo .txt");
            };

            if (datos.ShowDialog() == DialogResult.OK)
            {
                string archivo_txt = datos.FileName;
                string texto = File.ReadAllText(archivo_txt);

                rbtArchivo.Text = texto;
            }
        }
    }
}
