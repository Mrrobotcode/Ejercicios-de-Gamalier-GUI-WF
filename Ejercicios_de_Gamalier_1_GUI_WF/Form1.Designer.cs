namespace Ejercicios_de_Gamalier_1_GUI_WF
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
            label3 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtResta = new TextBox();
            txtMulti = new TextBox();
            txtDi = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 40);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 104);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 167);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Suma";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(130, 40);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(130, 104);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(154, 167);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(263, 40);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(263, 82);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(263, 122);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtResta
            // 
            txtResta.Location = new Point(154, 196);
            txtResta.Name = "txtResta";
            txtResta.Size = new Size(100, 23);
            txtResta.TabIndex = 9;
            // 
            // txtMulti
            // 
            txtMulti.Location = new Point(154, 230);
            txtMulti.Name = "txtMulti";
            txtMulti.Size = new Size(100, 23);
            txtMulti.TabIndex = 10;
            // 
            // txtDi
            // 
            txtDi.Location = new Point(154, 272);
            txtDi.Name = "txtDi";
            txtDi.Size = new Size(100, 23);
            txtDi.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 204);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 12;
            label4.Text = "Resta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 238);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 13;
            label5.Text = "Multiplicacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 272);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 14;
            label6.Text = "Division";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 344);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDi);
            Controls.Add(txtMulti);
            Controls.Add(txtResta);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtResta;
        private TextBox txtMulti;
        private TextBox txtDi;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
