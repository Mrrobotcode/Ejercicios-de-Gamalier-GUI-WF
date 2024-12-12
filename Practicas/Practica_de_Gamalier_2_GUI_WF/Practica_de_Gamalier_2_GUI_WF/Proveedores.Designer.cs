namespace Practica_de_Gamalier_2_GUI_WF
{
    partial class Proveedores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombreProveedor = new TextBox();
            txtDireccion = new TextBox();
            txtRNC = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnLimpiarCamposProveedores = new Button();
            btnAgregarProveedores = new Button();
            btnSalirProveedores = new Button();
            lbOpcionesForm = new Label();
            cbCuidad = new ComboBox();
            tabPage1 = new TabPage();
            txtBuscarProveedor = new TextBox();
            btnBuscarProveedorLista = new Button();
            btnEliminarListaProveedores = new Button();
            btnSalirListaProveedores = new Button();
            label10 = new Label();
            btnLimpiarListaProveedores = new Button();
            dgvListaProveedores = new DataGridView();
            identifica = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            RNC = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Cuidad = new DataGridViewTextBoxColumn();
            label9 = new Label();
            tabControl1 = new TabControl();
            btnModificarProveedores = new Button();
            btnMostraListaProveedores = new Button();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProveedores).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(186, 40);
            label1.Name = "label1";
            label1.Size = new Size(300, 23);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Proveedores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(183, 195);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(183, 335);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 2;
            label3.Text = "Cuidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(183, 242);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(183, 288);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(183, 147);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 5;
            label6.Text = "RNC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(183, 99);
            label7.Name = "label7";
            label7.Size = new Size(88, 23);
            label7.TabIndex = 6;
            label7.Text = "Nombre";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(312, 99);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(212, 23);
            txtNombreProveedor.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(312, 195);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(212, 23);
            txtDireccion.TabIndex = 8;
            // 
            // txtRNC
            // 
            txtRNC.Location = new Point(312, 151);
            txtRNC.Name = "txtRNC";
            txtRNC.Size = new Size(212, 23);
            txtRNC.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(312, 242);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(212, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(312, 288);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(212, 23);
            txtCorreo.TabIndex = 11;
            // 
            // btnLimpiarCamposProveedores
            // 
            btnLimpiarCamposProveedores.Location = new Point(23, 127);
            btnLimpiarCamposProveedores.Name = "btnLimpiarCamposProveedores";
            btnLimpiarCamposProveedores.Size = new Size(75, 23);
            btnLimpiarCamposProveedores.TabIndex = 13;
            btnLimpiarCamposProveedores.Text = "Limpiar";
            btnLimpiarCamposProveedores.UseVisualStyleBackColor = true;
            btnLimpiarCamposProveedores.Click += btnLimpiarCamposProveedores_Click;
            // 
            // btnAgregarProveedores
            // 
            btnAgregarProveedores.Location = new Point(23, 172);
            btnAgregarProveedores.Name = "btnAgregarProveedores";
            btnAgregarProveedores.Size = new Size(75, 23);
            btnAgregarProveedores.TabIndex = 14;
            btnAgregarProveedores.Text = "Agregar";
            btnAgregarProveedores.UseVisualStyleBackColor = true;
            btnAgregarProveedores.Click += btnAgregarProveedores_Click;
            // 
            // btnSalirProveedores
            // 
            btnSalirProveedores.Location = new Point(23, 219);
            btnSalirProveedores.Name = "btnSalirProveedores";
            btnSalirProveedores.Size = new Size(75, 23);
            btnSalirProveedores.TabIndex = 15;
            btnSalirProveedores.Text = "Salir";
            btnSalirProveedores.UseVisualStyleBackColor = true;
            btnSalirProveedores.Click += btnSalirProveedores_Click;
            // 
            // lbOpcionesForm
            // 
            lbOpcionesForm.AutoSize = true;
            lbOpcionesForm.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbOpcionesForm.ForeColor = Color.White;
            lbOpcionesForm.Location = new Point(10, 84);
            lbOpcionesForm.Name = "lbOpcionesForm";
            lbOpcionesForm.Size = new Size(102, 23);
            lbOpcionesForm.TabIndex = 16;
            lbOpcionesForm.Text = "Opciones\r\n";
            // 
            // cbCuidad
            // 
            cbCuidad.FormattingEnabled = true;
            cbCuidad.Items.AddRange(new object[] { "Higuey", "Santo Domingo", "Distrito Nacional", "Santiago", "San Pedro de Mascoris", "La Romana", "El Seibo", "Puerto Plata", "Hato Mayor", "Bahoruco ", "Barahona ", "Dajabón ", "Duarte ", "Elias Piña", "Hermanas Mirabal ", "Independencia", "San Cristóbal ", "Peravia ", "San José de Ocoa ", "Azua", "Dajabón ", "Espaillat ", "Montecristi ", "Puerto Plata ", "Santiago ", "Santiago Rodríguez ", "Valverde", "Monte Plata" });
            cbCuidad.Location = new Point(312, 339);
            cbCuidad.Name = "cbCuidad";
            cbCuidad.Size = new Size(212, 23);
            cbCuidad.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtBuscarProveedor);
            tabPage1.Controls.Add(btnBuscarProveedorLista);
            tabPage1.Controls.Add(btnEliminarListaProveedores);
            tabPage1.Controls.Add(btnSalirListaProveedores);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(btnLimpiarListaProveedores);
            tabPage1.Controls.Add(dgvListaProveedores);
            tabPage1.Controls.Add(label9);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(129, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Reporte de Proveedores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.Location = new Point(99, 85);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(100, 23);
            txtBuscarProveedor.TabIndex = 7;
            // 
            // btnBuscarProveedorLista
            // 
            btnBuscarProveedorLista.Location = new Point(114, 117);
            btnBuscarProveedorLista.Name = "btnBuscarProveedorLista";
            btnBuscarProveedorLista.Size = new Size(75, 23);
            btnBuscarProveedorLista.TabIndex = 6;
            btnBuscarProveedorLista.Text = "Buscar";
            btnBuscarProveedorLista.UseVisualStyleBackColor = true;
            btnBuscarProveedorLista.Click += btnBuscarProveedorLista_Click;
            // 
            // btnEliminarListaProveedores
            // 
            btnEliminarListaProveedores.Location = new Point(18, 84);
            btnEliminarListaProveedores.Name = "btnEliminarListaProveedores";
            btnEliminarListaProveedores.Size = new Size(75, 23);
            btnEliminarListaProveedores.TabIndex = 5;
            btnEliminarListaProveedores.Text = "Eliminar";
            btnEliminarListaProveedores.UseVisualStyleBackColor = true;
            btnEliminarListaProveedores.Click += btnEliminarListaProveedores_Click;
            // 
            // btnSalirListaProveedores
            // 
            btnSalirListaProveedores.Location = new Point(18, 117);
            btnSalirListaProveedores.Name = "btnSalirListaProveedores";
            btnSalirListaProveedores.Size = new Size(75, 23);
            btnSalirListaProveedores.TabIndex = 4;
            btnSalirListaProveedores.Text = "Salir";
            btnSalirListaProveedores.UseVisualStyleBackColor = true;
            btnSalirListaProveedores.Click += btnSalirListaProveedores_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(7, 14);
            label10.Name = "label10";
            label10.Size = new Size(102, 23);
            label10.TabIndex = 3;
            label10.Text = "Opciones\r\n";
            // 
            // btnLimpiarListaProveedores
            // 
            btnLimpiarListaProveedores.Location = new Point(18, 50);
            btnLimpiarListaProveedores.Name = "btnLimpiarListaProveedores";
            btnLimpiarListaProveedores.Size = new Size(75, 23);
            btnLimpiarListaProveedores.TabIndex = 2;
            btnLimpiarListaProveedores.Text = "Limpiar";
            btnLimpiarListaProveedores.UseVisualStyleBackColor = true;
            btnLimpiarListaProveedores.Click += btnLimpiarListaProveedores_Click;
            // 
            // dgvListaProveedores
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProveedores.Columns.AddRange(new DataGridViewColumn[] { identifica, Nombre, RNC, Direccion, Telefono, Correo, Cuidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListaProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListaProveedores.Location = new Point(76, 163);
            dgvListaProveedores.Name = "dgvListaProveedores";
            dgvListaProveedores.ScrollBars = ScrollBars.Vertical;
            dgvListaProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaProveedores.Size = new Size(644, 182);
            dgvListaProveedores.TabIndex = 1;
            dgvListaProveedores.CellClick += dgvListaProveedores_CellClick;
            // 
            // identifica
            // 
            identifica.HeaderText = "ID";
            identifica.Name = "identifica";
            identifica.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // RNC
            // 
            RNC.HeaderText = "RNC";
            RNC.Name = "RNC";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Cuidad
            // 
            Cuidad.HeaderText = "Cuidad";
            Cuidad.Name = "Cuidad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(252, 84);
            label9.Name = "label9";
            label9.Size = new Size(267, 23);
            label9.TabIndex = 0;
            label9.Text = "Reporte de Proveedores";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(137, 26);
            tabControl1.TabIndex = 18;
            tabControl1.Click += tabControl1_Click;
            // 
            // btnModificarProveedores
            // 
            btnModificarProveedores.Location = new Point(23, 266);
            btnModificarProveedores.Name = "btnModificarProveedores";
            btnModificarProveedores.Size = new Size(75, 23);
            btnModificarProveedores.TabIndex = 19;
            btnModificarProveedores.Text = "Modificar";
            btnModificarProveedores.UseVisualStyleBackColor = true;
            btnModificarProveedores.Click += btnModificarProveedores_Click;
            // 
            // btnMostraListaProveedores
            // 
            btnMostraListaProveedores.Location = new Point(23, 312);
            btnMostraListaProveedores.Name = "btnMostraListaProveedores";
            btnMostraListaProveedores.Size = new Size(75, 23);
            btnMostraListaProveedores.TabIndex = 20;
            btnMostraListaProveedores.Text = "Mostrar";
            btnMostraListaProveedores.UseVisualStyleBackColor = true;
            btnMostraListaProveedores.Click += btnMostraListaProveedores_Click;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(596, 383);
            ControlBox = false;
            Controls.Add(btnMostraListaProveedores);
            Controls.Add(btnModificarProveedores);
            Controls.Add(tabControl1);
            Controls.Add(cbCuidad);
            Controls.Add(lbOpcionesForm);
            Controls.Add(btnSalirProveedores);
            Controls.Add(btnAgregarProveedores);
            Controls.Add(btnLimpiarCamposProveedores);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtRNC);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombreProveedor);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Proveedores";
            Text = "Proveedores";
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProveedores).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombreProveedor;
        private TextBox txtDireccion;
        private TextBox txtRNC;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnLimpiarCamposProveedores;
        private Button btnAgregarProveedores;
        private Button btnSalirProveedores;
        private Label lbOpcionesForm;
        private ComboBox cbCuidad;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private Button btnModificarProveedores;
        private Label label10;
        private Button btnLimpiarListaProveedores;
        private DataGridView dgvListaProveedores;
        private Label label9;
        private Button btnEliminarListaProveedores;
        private Button btnSalirListaProveedores;
        private TextBox txtBuscarProveedor;
        private Button btnBuscarProveedorLista;
        private DataGridViewTextBoxColumn identifica;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn RNC;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Cuidad;
        private Button btnMostraListaProveedores;
    }
}