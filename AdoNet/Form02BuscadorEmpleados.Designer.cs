namespace AdoNet
{
    partial class Form02BuscadorEmpleados
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
            btnBuscarSalario = new Button();
            txtSalario = new TextBox();
            lblSalario = new Label();
            label1 = new Label();
            lstEmpleados = new ListBox();
            label2 = new Label();
            txtOficio = new TextBox();
            btnBuscarOficios = new Button();
            SuspendLayout();
            // 
            // btnBuscarSalario
            // 
            btnBuscarSalario.Location = new Point(175, 132);
            btnBuscarSalario.Name = "btnBuscarSalario";
            btnBuscarSalario.Size = new Size(113, 41);
            btnBuscarSalario.TabIndex = 0;
            btnBuscarSalario.Text = "Buscar Salario";
            btnBuscarSalario.UseVisualStyleBackColor = true;
            btnBuscarSalario.Click += btnBuscarSalario_Click;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(164, 93);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(134, 23);
            txtSalario.TabIndex = 1;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(164, 75);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(42, 15);
            lblSalario.TabIndex = 2;
            lblSalario.Text = "Salario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 188);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(164, 215);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(289, 169);
            lstEmpleados.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 75);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(319, 93);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(134, 23);
            txtOficio.TabIndex = 5;
            // 
            // btnBuscarOficios
            // 
            btnBuscarOficios.Location = new Point(331, 132);
            btnBuscarOficios.Name = "btnBuscarOficios";
            btnBuscarOficios.Size = new Size(113, 41);
            btnBuscarOficios.TabIndex = 7;
            btnBuscarOficios.Text = "Buscar Oficios";
            btnBuscarOficios.UseVisualStyleBackColor = true;
            btnBuscarOficios.Click += btnBuscarOficios_Click;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 527);
            Controls.Add(btnBuscarOficios);
            Controls.Add(label2);
            Controls.Add(txtOficio);
            Controls.Add(lstEmpleados);
            Controls.Add(label1);
            Controls.Add(lblSalario);
            Controls.Add(txtSalario);
            Controls.Add(btnBuscarSalario);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarSalario;
        private TextBox txtSalario;
        private Label lblSalario;
        private Label label1;
        private ListBox lstEmpleados;
        private Label label2;
        private TextBox txtOficio;
        private Button btnBuscarOficios;
    }
}