namespace Ejercicios_de_Gamalier_5_GUI_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTabla = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Total_General = new DataGridViewTextBoxColumn();
            Cantidad_Efectivo = new DataGridViewTextBoxColumn();
            Cambio = new DataGridViewTextBoxColumn();
            Sub_Total = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            btnGuardarArchivo = new Button();
            btnSalir = new Button();
            cbArticulos = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnEliminar = new Button();
            txtEfectivo = new TextBox();
            Efectivo = new Label();
            rbtArchivo = new RichTextBox();
            btnMostrarArchivo = new Button();
            txtCantidadArticulo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // dgvTabla
            // 
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Precio, Total_General, Cantidad_Efectivo, Cambio, Sub_Total });
            dgvTabla.Location = new Point(31, 285);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTabla.Size = new Size(740, 150);
            dgvTabla.TabIndex = 0;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Total_General
            // 
            Total_General.HeaderText = "Total_General";
            Total_General.Name = "Total_General";
            // 
            // Cantidad_Efectivo
            // 
            Cantidad_Efectivo.HeaderText = "Cantidad_Efectivo";
            Cantidad_Efectivo.Name = "Cantidad_Efectivo";
            // 
            // Cambio
            // 
            Cambio.HeaderText = "Cambio";
            Cambio.Name = "Cambio";
            // 
            // Sub_Total
            // 
            Sub_Total.HeaderText = "Sub_Total";
            Sub_Total.Name = "Sub_Total";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(31, 104);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(31, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnGuardarArchivo
            // 
            btnGuardarArchivo.Location = new Point(31, 60);
            btnGuardarArchivo.Name = "btnGuardarArchivo";
            btnGuardarArchivo.Size = new Size(111, 23);
            btnGuardarArchivo.TabIndex = 3;
            btnGuardarArchivo.Text = "Guardar Archivo";
            btnGuardarArchivo.UseVisualStyleBackColor = true;
            btnGuardarArchivo.Click += btnGuardarArchivo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(31, 154);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cbArticulos
            // 
            cbArticulos.FormattingEnabled = true;
            cbArticulos.Location = new Point(278, 46);
            cbArticulos.Name = "cbArticulos";
            cbArticulos.Size = new Size(187, 23);
            cbArticulos.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 20);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Articulos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 20);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Cantidad";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(31, 200);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtEfectivo
            // 
            txtEfectivo.Location = new Point(321, 135);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(100, 23);
            txtEfectivo.TabIndex = 10;
            // 
            // Efectivo
            // 
            Efectivo.AutoSize = true;
            Efectivo.Location = new Point(348, 108);
            Efectivo.Name = "Efectivo";
            Efectivo.Size = new Size(49, 15);
            Efectivo.TabIndex = 11;
            Efectivo.Text = "Efectivo";
            // 
            // rbtArchivo
            // 
            rbtArchivo.Location = new Point(223, 459);
            rbtArchivo.Name = "rbtArchivo";
            rbtArchivo.Size = new Size(357, 214);
            rbtArchivo.TabIndex = 12;
            rbtArchivo.Text = "";
            // 
            // btnMostrarArchivo
            // 
            btnMostrarArchivo.Location = new Point(31, 247);
            btnMostrarArchivo.Name = "btnMostrarArchivo";
            btnMostrarArchivo.Size = new Size(111, 23);
            btnMostrarArchivo.TabIndex = 13;
            btnMostrarArchivo.Text = "Mostrar Archivo";
            btnMostrarArchivo.UseVisualStyleBackColor = true;
            btnMostrarArchivo.Click += btnMostrarArchivo_Click;
            // 
            // txtCantidadArticulo
            // 
            txtCantidadArticulo.Location = new Point(572, 46);
            txtCantidadArticulo.Name = "txtCantidadArticulo";
            txtCantidadArticulo.Size = new Size(100, 23);
            txtCantidadArticulo.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 698);
            Controls.Add(txtCantidadArticulo);
            Controls.Add(btnMostrarArchivo);
            Controls.Add(rbtArchivo);
            Controls.Add(Efectivo);
            Controls.Add(txtEfectivo);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbArticulos);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardarArchivo);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvTabla);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTabla;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Total_General;
        private DataGridViewTextBoxColumn Cantidad_Efectivo;
        private DataGridViewTextBoxColumn Cambio;
        private DataGridViewTextBoxColumn Sub_Total;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Button btnGuardarArchivo;
        private Button btnSalir;
        private ComboBox cbArticulos;
        private Label label1;
        private Label label2;
        private Button btnEliminar;
        private TextBox txtEfectivo;
        private Label Efectivo;
        private RichTextBox rbtArchivo;
        private Button btnMostrarArchivo;
        private TextBox txtCantidadArticulo;
    }
}
