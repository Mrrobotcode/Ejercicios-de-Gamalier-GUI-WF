namespace Practicas_de_Gamalier_1_GUI_WF
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
            tabControl1 = new TabControl();
            tpFormularios = new TabPage();
            cbCargo = new ComboBox();
            lbTotalDescuento = new Label();
            lbSueldoNeto = new Label();
            lbSFS = new Label();
            lbISR = new Label();
            lbOtros = new Label();
            lbAFP = new Label();
            btnExit = new Button();
            btnEdit = new Button();
            btnClear = new Button();
            btnSave = new Button();
            txtSueldo = new TextBox();
            txtHijos = new TextBox();
            txtNombreEmpleado = new TextBox();
            label5 = new Label();
            lbCargo = new Label();
            label3 = new Label();
            lbSueldoBonificacion = new Label();
            label1 = new Label();
            tpDatosVisualizacion = new TabPage();
            btnDelete = new Button();
            btnGeneraArchivo = new Button();
            dgvDatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Hijos = new DataGridViewTextBoxColumn();
            Sueldo_Bonificacion = new DataGridViewTextBoxColumn();
            AFP = new DataGridViewTextBoxColumn();
            SFS = new DataGridViewTextBoxColumn();
            ISR = new DataGridViewTextBoxColumn();
            Otros = new DataGridViewTextBoxColumn();
            Total_Descuento = new DataGridViewTextBoxColumn();
            Sueldo_Neto = new DataGridViewTextBoxColumn();
            btnClearDatos = new Button();
            tabControl1.SuspendLayout();
            tpFormularios.SuspendLayout();
            tpDatosVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpFormularios);
            tabControl1.Controls.Add(tpDatosVisualizacion);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Margin = new Padding(10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1300, 800);
            tabControl1.TabIndex = 9;
            // 
            // tpFormularios
            // 
            tpFormularios.Controls.Add(cbCargo);
            tpFormularios.Controls.Add(lbTotalDescuento);
            tpFormularios.Controls.Add(lbSueldoNeto);
            tpFormularios.Controls.Add(lbSFS);
            tpFormularios.Controls.Add(lbISR);
            tpFormularios.Controls.Add(lbOtros);
            tpFormularios.Controls.Add(lbAFP);
            tpFormularios.Controls.Add(btnExit);
            tpFormularios.Controls.Add(btnEdit);
            tpFormularios.Controls.Add(btnClear);
            tpFormularios.Controls.Add(btnSave);
            tpFormularios.Controls.Add(txtSueldo);
            tpFormularios.Controls.Add(txtHijos);
            tpFormularios.Controls.Add(txtNombreEmpleado);
            tpFormularios.Controls.Add(label5);
            tpFormularios.Controls.Add(lbCargo);
            tpFormularios.Controls.Add(label3);
            tpFormularios.Controls.Add(lbSueldoBonificacion);
            tpFormularios.Controls.Add(label1);
            tpFormularios.Location = new Point(4, 24);
            tpFormularios.Name = "tpFormularios";
            tpFormularios.Padding = new Padding(3);
            tpFormularios.Size = new Size(1292, 772);
            tpFormularios.TabIndex = 0;
            tpFormularios.Text = "Formulario y calculo de sueldo neto";
            tpFormularios.UseVisualStyleBackColor = true;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "Gerente", "Contable", "Desarrollador de software", "Desarrollador web", "Programador frontend", "Ingeniero de aplicaciones", "Arquitecto de infraestructura o de solución", "Técnico de sistemas", "Analista de seguridad informática", "Desarrollador de bases de datos", "Ingeniero de redes/nube" });
            cbCargo.Location = new Point(123, 93);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(187, 23);
            cbCargo.TabIndex = 21;
            // 
            // lbTotalDescuento
            // 
            lbTotalDescuento.AutoSize = true;
            lbTotalDescuento.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTotalDescuento.ForeColor = Color.Black;
            lbTotalDescuento.Location = new Point(502, 187);
            lbTotalDescuento.Name = "lbTotalDescuento";
            lbTotalDescuento.Size = new Size(181, 28);
            lbTotalDescuento.TabIndex = 20;
            lbTotalDescuento.Text = "Total Descuento:";
            // 
            // lbSueldoNeto
            // 
            lbSueldoNeto.AutoSize = true;
            lbSueldoNeto.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbSueldoNeto.ForeColor = Color.Black;
            lbSueldoNeto.Location = new Point(502, 232);
            lbSueldoNeto.Name = "lbSueldoNeto";
            lbSueldoNeto.Size = new Size(141, 28);
            lbSueldoNeto.TabIndex = 19;
            lbSueldoNeto.Text = "Sueldo Neto:";
            // 
            // lbSFS
            // 
            lbSFS.AutoSize = true;
            lbSFS.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbSFS.ForeColor = Color.Black;
            lbSFS.Location = new Point(502, 57);
            lbSFS.Name = "lbSFS";
            lbSFS.Size = new Size(62, 28);
            lbSFS.TabIndex = 18;
            lbSFS.Text = "SFS:";
            // 
            // lbISR
            // 
            lbISR.AutoSize = true;
            lbISR.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbISR.ForeColor = Color.Black;
            lbISR.Location = new Point(502, 103);
            lbISR.Name = "lbISR";
            lbISR.Size = new Size(58, 28);
            lbISR.TabIndex = 17;
            lbISR.Text = "ISR:";
            // 
            // lbOtros
            // 
            lbOtros.AutoSize = true;
            lbOtros.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbOtros.ForeColor = Color.Black;
            lbOtros.Location = new Point(502, 144);
            lbOtros.Name = "lbOtros";
            lbOtros.Size = new Size(74, 28);
            lbOtros.TabIndex = 16;
            lbOtros.Text = "Otros:";
            // 
            // lbAFP
            // 
            lbAFP.AutoSize = true;
            lbAFP.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbAFP.ForeColor = Color.Black;
            lbAFP.Location = new Point(502, 15);
            lbAFP.Name = "lbAFP";
            lbAFP.Size = new Size(67, 28);
            lbAFP.TabIndex = 15;
            lbAFP.Text = "AFP:";
            // 
            // btnExit
            // 
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(398, 322);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 33);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEdit
            // 
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(150, 322);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(93, 33);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(272, 322);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 33);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(14, 322);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 33);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSueldo
            // 
            txtSueldo.BackColor = SystemColors.Window;
            txtSueldo.Location = new Point(123, 149);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(187, 23);
            txtSueldo.TabIndex = 8;
            // 
            // txtHijos
            // 
            txtHijos.BackColor = SystemColors.Window;
            txtHijos.Location = new Point(208, 204);
            txtHijos.Name = "txtHijos";
            txtHijos.Size = new Size(187, 23);
            txtHijos.TabIndex = 7;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.BackColor = SystemColors.Window;
            txtNombreEmpleado.Location = new Point(123, 37);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(187, 23);
            txtNombreEmpleado.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(8, 198);
            label5.Name = "label5";
            label5.Size = new Size(194, 28);
            label5.TabIndex = 4;
            label5.Text = "Cantidad de hijos:";
            // 
            // lbCargo
            // 
            lbCargo.AutoSize = true;
            lbCargo.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbCargo.ForeColor = Color.Black;
            lbCargo.Location = new Point(8, 86);
            lbCargo.Name = "lbCargo";
            lbCargo.Size = new Size(81, 28);
            lbCargo.TabIndex = 3;
            lbCargo.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 142);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 2;
            label3.Text = "Sueldo:";
            // 
            // lbSueldoBonificacion
            // 
            lbSueldoBonificacion.AutoSize = true;
            lbSueldoBonificacion.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbSueldoBonificacion.ForeColor = Color.Black;
            lbSueldoBonificacion.Location = new Point(8, 260);
            lbSueldoBonificacion.Name = "lbSueldoBonificacion";
            lbSueldoBonificacion.Size = new Size(243, 28);
            lbSueldoBonificacion.TabIndex = 1;
            lbSueldoBonificacion.Text = "Sueldo + Bonificacion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 32);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // tpDatosVisualizacion
            // 
            tpDatosVisualizacion.Controls.Add(btnClearDatos);
            tpDatosVisualizacion.Controls.Add(btnDelete);
            tpDatosVisualizacion.Controls.Add(btnGeneraArchivo);
            tpDatosVisualizacion.Controls.Add(dgvDatos);
            tpDatosVisualizacion.Location = new Point(4, 24);
            tpDatosVisualizacion.Name = "tpDatosVisualizacion";
            tpDatosVisualizacion.Padding = new Padding(3);
            tpDatosVisualizacion.Size = new Size(1292, 772);
            tpDatosVisualizacion.TabIndex = 1;
            tpDatosVisualizacion.Text = "Datos y visualizacion de datos";
            tpDatosVisualizacion.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(151, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 33);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGeneraArchivo
            // 
            btnGeneraArchivo.ForeColor = Color.Black;
            btnGeneraArchivo.Location = new Point(8, 368);
            btnGeneraArchivo.Name = "btnGeneraArchivo";
            btnGeneraArchivo.Size = new Size(116, 33);
            btnGeneraArchivo.TabIndex = 1;
            btnGeneraArchivo.Text = "Genera archivo";
            btnGeneraArchivo.UseVisualStyleBackColor = true;
            btnGeneraArchivo.Click += btnGeneraArchivo_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Cargo, Sueldo, Hijos, Sueldo_Bonificacion, AFP, SFS, ISR, Otros, Total_Descuento, Sueldo_Neto });
            dgvDatos.Location = new Point(8, 63);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1142, 282);
            dgvDatos.TabIndex = 0;
            dgvDatos.CellClick += dgvDatos_CellClick_1;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            // 
            // Sueldo
            // 
            Sueldo.HeaderText = "Sueldo";
            Sueldo.Name = "Sueldo";
            // 
            // Hijos
            // 
            Hijos.HeaderText = "Hijos";
            Hijos.Name = "Hijos";
            // 
            // Sueldo_Bonificacion
            // 
            Sueldo_Bonificacion.HeaderText = "Sueldo_Bonificacion";
            Sueldo_Bonificacion.Name = "Sueldo_Bonificacion";
            // 
            // AFP
            // 
            AFP.HeaderText = "AFP";
            AFP.Name = "AFP";
            // 
            // SFS
            // 
            SFS.HeaderText = "SFS";
            SFS.Name = "SFS";
            // 
            // ISR
            // 
            ISR.HeaderText = "ISR";
            ISR.Name = "ISR";
            // 
            // Otros
            // 
            Otros.HeaderText = "Otros";
            Otros.Name = "Otros";
            // 
            // Total_Descuento
            // 
            Total_Descuento.HeaderText = "Total_Descuento";
            Total_Descuento.Name = "Total_Descuento";
            // 
            // Sueldo_Neto
            // 
            Sueldo_Neto.HeaderText = "Sueldo_Neto";
            Sueldo_Neto.Name = "Sueldo_Neto";
            // 
            // btnClearDatos
            // 
            btnClearDatos.ForeColor = Color.Black;
            btnClearDatos.Location = new Point(281, 368);
            btnClearDatos.Name = "btnClearDatos";
            btnClearDatos.Size = new Size(99, 33);
            btnClearDatos.TabIndex = 5;
            btnClearDatos.Text = "Clear";
            btnClearDatos.UseVisualStyleBackColor = true;
            btnClearDatos.Click += btnClearDatos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1147, 440);
            Controls.Add(tabControl1);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tpFormularios.ResumeLayout(false);
            tpFormularios.PerformLayout();
            tpDatosVisualizacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpFormularios;
        private TabPage tpDatosVisualizacion;
        private Label label5;
        private Label lbCargo;
        private Label label3;
        private Label lbSueldoBonificacion;
        private Label label1;
        private TextBox txtNombreEmpleado;
        private TextBox txtSueldo;
        private TextBox txtHijos;
        private Button btnSave;
        private Button btnExit;
        private Button btnEdit;
        private Button btnClear;
        private Label label7;
        private Label lbTotalDescuento;
        private Label lbSueldoNeto;
        private Label lbSFS;
        private Label lbISR;
        private Label lbOtros;
        private Label lbAFP;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Hijos;
        private DataGridViewTextBoxColumn Sueldo_Bonificacion;
        private DataGridViewTextBoxColumn AFP;
        private DataGridViewTextBoxColumn SFS;
        private DataGridViewTextBoxColumn ISR;
        private DataGridViewTextBoxColumn Otros;
        private DataGridViewTextBoxColumn Total_Descuento;
        private DataGridViewTextBoxColumn Sueldo_Neto;
        private Button btnGeneraArchivo;
        private ComboBox cbCargo;
        private Button btnDelete;
        private Button btnClearDatos;
    }
}
