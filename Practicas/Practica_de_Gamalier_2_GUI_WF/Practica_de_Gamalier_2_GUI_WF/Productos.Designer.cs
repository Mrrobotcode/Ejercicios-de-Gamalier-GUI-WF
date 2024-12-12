namespace Practica_de_Gamalier_2_GUI_WF
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreProducto = new TextBox();
            txtCategoriaProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtStockProducto = new TextBox();
            btnLimpiarCamposProducto = new Button();
            btnAgregarProductos = new Button();
            btnSalirProductos = new Button();
            tcReportesProductos = new TabControl();
            tabPage2 = new TabPage();
            txtBuscarProductoLista = new TextBox();
            btnBuscarProductoLista = new Button();
            label7 = new Label();
            btnSalirListaProductos = new Button();
            btnLimpiarListaProductos = new Button();
            btnEliminarListaProductos = new Button();
            label6 = new Label();
            dgvListaProductos = new DataGridView();
            numero = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            lbOpcionesFormProductos = new Label();
            btnModificarProductos = new Button();
            btnMostraListaProductos = new Button();
            tcReportesProductos.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 39);
            label1.Name = "label1";
            label1.Size = new Size(279, 23);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(161, 271);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 1;
            label2.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(161, 217);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(161, 165);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(161, 118);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 4;
            label5.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(291, 118);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(250, 23);
            txtNombreProducto.TabIndex = 5;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.Location = new Point(291, 165);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(250, 23);
            txtCategoriaProducto.TabIndex = 6;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(291, 216);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(250, 23);
            txtPrecioProducto.TabIndex = 7;
            // 
            // txtStockProducto
            // 
            txtStockProducto.Location = new Point(291, 266);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(250, 23);
            txtStockProducto.TabIndex = 8;
            // 
            // btnLimpiarCamposProducto
            // 
            btnLimpiarCamposProducto.Location = new Point(12, 159);
            btnLimpiarCamposProducto.Name = "btnLimpiarCamposProducto";
            btnLimpiarCamposProducto.Size = new Size(75, 23);
            btnLimpiarCamposProducto.TabIndex = 9;
            btnLimpiarCamposProducto.Text = "Limpiar";
            btnLimpiarCamposProducto.UseVisualStyleBackColor = true;
            btnLimpiarCamposProducto.Click += btnLimpiarCamposProducto_Click;
            // 
            // btnAgregarProductos
            // 
            btnAgregarProductos.Location = new Point(12, 205);
            btnAgregarProductos.Name = "btnAgregarProductos";
            btnAgregarProductos.Size = new Size(75, 23);
            btnAgregarProductos.TabIndex = 10;
            btnAgregarProductos.Text = "Agregar";
            btnAgregarProductos.UseVisualStyleBackColor = true;
            btnAgregarProductos.Click += btnAgregarProductos_Click;
            // 
            // btnSalirProductos
            // 
            btnSalirProductos.Location = new Point(12, 252);
            btnSalirProductos.Name = "btnSalirProductos";
            btnSalirProductos.Size = new Size(75, 23);
            btnSalirProductos.TabIndex = 11;
            btnSalirProductos.Text = "Salir";
            btnSalirProductos.UseVisualStyleBackColor = true;
            btnSalirProductos.Click += btnSalirProductos_Click;
            // 
            // tcReportesProductos
            // 
            tcReportesProductos.Controls.Add(tabPage2);
            tcReportesProductos.Location = new Point(2, 2);
            tcReportesProductos.Name = "tcReportesProductos";
            tcReportesProductos.SelectedIndex = 0;
            tcReportesProductos.Size = new Size(134, 26);
            tcReportesProductos.TabIndex = 12;
            tcReportesProductos.Click += tcReportesProductos_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtBuscarProductoLista);
            tabPage2.Controls.Add(btnBuscarProductoLista);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btnSalirListaProductos);
            tabPage2.Controls.Add(btnLimpiarListaProductos);
            tabPage2.Controls.Add(btnEliminarListaProductos);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(dgvListaProductos);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(126, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Reportes de Productos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProductoLista
            // 
            txtBuscarProductoLista.Location = new Point(14, 195);
            txtBuscarProductoLista.Name = "txtBuscarProductoLista";
            txtBuscarProductoLista.Size = new Size(100, 23);
            txtBuscarProductoLista.TabIndex = 7;
            // 
            // btnBuscarProductoLista
            // 
            btnBuscarProductoLista.Location = new Point(27, 226);
            btnBuscarProductoLista.Name = "btnBuscarProductoLista";
            btnBuscarProductoLista.Size = new Size(75, 23);
            btnBuscarProductoLista.TabIndex = 6;
            btnBuscarProductoLista.Text = "Buscar";
            btnBuscarProductoLista.UseVisualStyleBackColor = true;
            btnBuscarProductoLista.Click += btnBuscarProductoLista_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 33);
            label7.Name = "label7";
            label7.Size = new Size(102, 23);
            label7.TabIndex = 5;
            label7.Text = "Opciones";
            // 
            // btnSalirListaProductos
            // 
            btnSalirListaProductos.Location = new Point(27, 162);
            btnSalirListaProductos.Name = "btnSalirListaProductos";
            btnSalirListaProductos.Size = new Size(75, 23);
            btnSalirListaProductos.TabIndex = 4;
            btnSalirListaProductos.Text = "Salir";
            btnSalirListaProductos.UseVisualStyleBackColor = true;
            btnSalirListaProductos.Click += btnSalirListaProductos_Click;
            // 
            // btnLimpiarListaProductos
            // 
            btnLimpiarListaProductos.Location = new Point(27, 70);
            btnLimpiarListaProductos.Name = "btnLimpiarListaProductos";
            btnLimpiarListaProductos.Size = new Size(75, 23);
            btnLimpiarListaProductos.TabIndex = 3;
            btnLimpiarListaProductos.Text = "Limpiar";
            btnLimpiarListaProductos.UseVisualStyleBackColor = true;
            btnLimpiarListaProductos.Click += btnLimpiarListaProductos_Click;
            // 
            // btnEliminarListaProductos
            // 
            btnEliminarListaProductos.Location = new Point(27, 116);
            btnEliminarListaProductos.Name = "btnEliminarListaProductos";
            btnEliminarListaProductos.Size = new Size(75, 23);
            btnEliminarListaProductos.TabIndex = 2;
            btnEliminarListaProductos.Text = "Eliminar";
            btnEliminarListaProductos.UseVisualStyleBackColor = true;
            btnEliminarListaProductos.Click += btnEliminarListaProductos_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(289, 40);
            label6.Name = "label6";
            label6.Size = new Size(210, 23);
            label6.TabIndex = 1;
            label6.Text = "Lista de productos";
            // 
            // dgvListaProductos
            // 
            dgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProductos.Columns.AddRange(new DataGridViewColumn[] { numero, Nombre, Categoria, Precio, Stock });
            dgvListaProductos.Location = new Point(177, 116);
            dgvListaProductos.Margin = new Padding(6);
            dgvListaProductos.Name = "dgvListaProductos";
            dgvListaProductos.ScrollBars = ScrollBars.Vertical;
            dgvListaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaProductos.Size = new Size(435, 195);
            dgvListaProductos.TabIndex = 0;
            dgvListaProductos.CellClick += dgvListaProductos_CellClick;
            // 
            // numero
            // 
            numero.HeaderText = "ID";
            numero.Name = "numero";
            numero.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // lbOpcionesFormProductos
            // 
            lbOpcionesFormProductos.AutoSize = true;
            lbOpcionesFormProductos.BackColor = Color.Black;
            lbOpcionesFormProductos.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbOpcionesFormProductos.ForeColor = Color.White;
            lbOpcionesFormProductos.Location = new Point(6, 118);
            lbOpcionesFormProductos.Name = "lbOpcionesFormProductos";
            lbOpcionesFormProductos.Size = new Size(102, 23);
            lbOpcionesFormProductos.TabIndex = 13;
            lbOpcionesFormProductos.Text = "Opciones";
            // 
            // btnModificarProductos
            // 
            btnModificarProductos.Location = new Point(12, 299);
            btnModificarProductos.Name = "btnModificarProductos";
            btnModificarProductos.Size = new Size(75, 23);
            btnModificarProductos.TabIndex = 14;
            btnModificarProductos.Text = "Modificar";
            btnModificarProductos.UseVisualStyleBackColor = true;
            btnModificarProductos.Click += btnModificarProductos_Click;
            // 
            // btnMostraListaProductos
            // 
            btnMostraListaProductos.Location = new Point(12, 345);
            btnMostraListaProductos.Name = "btnMostraListaProductos";
            btnMostraListaProductos.Size = new Size(75, 23);
            btnMostraListaProductos.TabIndex = 15;
            btnMostraListaProductos.Text = "Mostrar";
            btnMostraListaProductos.UseVisualStyleBackColor = true;
            btnMostraListaProductos.Click += btnMostraListaProductos_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(640, 380);
            ControlBox = false;
            Controls.Add(btnMostraListaProductos);
            Controls.Add(btnModificarProductos);
            Controls.Add(lbOpcionesFormProductos);
            Controls.Add(tcReportesProductos);
            Controls.Add(btnSalirProductos);
            Controls.Add(btnAgregarProductos);
            Controls.Add(btnLimpiarCamposProducto);
            Controls.Add(txtStockProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtCategoriaProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Productos";
            Text = "Productos";
            tcReportesProductos.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombreProducto;
        private TextBox txtCategoriaProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtStockProducto;
        private Button btnLimpiarCamposProducto;
        private Button btnAgregarProductos;
        private Button btnSalirProductos;
        private TabControl tcReportesProductos;
        private TabPage tabPage2;
        private Label label6;
        private DataGridView dgvListaProductos;
        private Button btnEliminarListaProductos;
        private Label label7;
        private Button btnSalirListaProductos;
        private Button btnLimpiarListaProductos;
        private Label lbOpcionesFormProductos;
        private Button btnModificarProductos;
        private Button btnBuscarProductoLista;
        private TextBox txtBuscarProductoLista;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private Button btnMostraListaProductos;
    }
}