namespace Ejercicios_de_Gamalier_4_GUI_WF
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
            label1 = new Label();
            label2 = new Label();
            txtNombreCliente = new TextBox();
            cbTipoHabitacion = new ComboBox();
            label3 = new Label();
            cbPrecio = new ComboBox();
            label4 = new Label();
            dtpDesde = new DateTimePicker();
            label5 = new Label();
            dtpHasta = new DateTimePicker();
            label6 = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            dgvDatos = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Habitacion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Desde = new DataGridViewTextBoxColumn();
            Hasta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(207, 37);
            label1.Name = "label1";
            label1.Size = new Size(124, 36);
            label1.TabIndex = 0;
            label1.Text = "Reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 128);
            label2.Name = "label2";
            label2.Size = new Size(173, 22);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Cliente:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(260, 130);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(167, 23);
            txtNombreCliente.TabIndex = 2;
            // 
            // cbTipoHabitacion
            // 
            cbTipoHabitacion.FormattingEnabled = true;
            cbTipoHabitacion.Items.AddRange(new object[] { "Estandar", "Premium", "Suites", "Privadas" });
            cbTipoHabitacion.Location = new Point(261, 188);
            cbTipoHabitacion.Name = "cbTipoHabitacion";
            cbTipoHabitacion.Size = new Size(167, 23);
            cbTipoHabitacion.TabIndex = 3;
            cbTipoHabitacion.SelectedIndexChanged += cbTipoHabitacion_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 186);
            label3.Name = "label3";
            label3.Size = new Size(171, 22);
            label3.TabIndex = 4;
            label3.Text = "Tipo de Habitacion:";
            // 
            // cbPrecio
            // 
            cbPrecio.FormattingEnabled = true;
            cbPrecio.Items.AddRange(new object[] { "50", "100", "400", "1000" });
            cbPrecio.Location = new Point(261, 252);
            cbPrecio.Name = "cbPrecio";
            cbPrecio.Size = new Size(166, 23);
            cbPrecio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 250);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(261, 312);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(200, 23);
            dtpDesde.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(50, 312);
            label5.Name = "label5";
            label5.Size = new Size(65, 22);
            label5.TabIndex = 8;
            label5.Text = "Desde:";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(260, 365);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(200, 23);
            dtpHasta.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 365);
            label6.Name = "label6";
            label6.Size = new Size(58, 22);
            label6.TabIndex = 10;
            label6.Text = "Hasta";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(50, 588);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(173, 588);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(294, 588);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(425, 588);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Cliente, Habitacion, Precio, Desde, Hasta });
            dgvDatos.Location = new Point(12, 412);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(540, 150);
            dgvDatos.TabIndex = 16;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            // 
            // Habitacion
            // 
            Habitacion.HeaderText = "Habitacion";
            Habitacion.Name = "Habitacion";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Desde
            // 
            Desde.HeaderText = "Desde";
            Desde.Name = "Desde";
            // 
            // Hasta
            // 
            Hasta.HeaderText = "Hasta";
            Hasta.Name = "Hasta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(559, 669);
            Controls.Add(dgvDatos);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(dtpHasta);
            Controls.Add(label5);
            Controls.Add(dtpDesde);
            Controls.Add(label4);
            Controls.Add(cbPrecio);
            Controls.Add(label3);
            Controls.Add(cbTipoHabitacion);
            Controls.Add(txtNombreCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombreCliente;
        private ComboBox cbTipoHabitacion;
        private Label label3;
        private ComboBox cbPrecio;
        private Label label4;
        private DateTimePicker dtpDesde;
        private Label label5;
        private DateTimePicker dtpHasta;
        private Label label6;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Habitacion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Desde;
        private DataGridViewTextBoxColumn Hasta;
    }
}
