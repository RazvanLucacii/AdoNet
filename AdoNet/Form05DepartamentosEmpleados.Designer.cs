namespace AdoNet
{
    partial class Form05DepartamentosEmpleados
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
            lstDepartamentos = new ListBox();
            lstEmpleados = new ListBox();
            label3 = new Label();
            label4 = new Label();
            txtOficio = new TextBox();
            txtSalario = new TextBox();
            btnModificarDatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 46);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 46);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.ItemHeight = 15;
            lstDepartamentos.Location = new Point(49, 64);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(159, 319);
            lstDepartamentos.TabIndex = 2;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(267, 64);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(159, 319);
            lstEmpleados.TabIndex = 3;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(545, 46);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Oficio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(546, 122);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Salario";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(545, 64);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 6;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(546, 140);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 7;
            // 
            // btnModificarDatos
            // 
            btnModificarDatos.Location = new Point(546, 202);
            btnModificarDatos.Name = "btnModificarDatos";
            btnModificarDatos.Size = new Size(118, 46);
            btnModificarDatos.TabIndex = 8;
            btnModificarDatos.Text = "Modificar Datos";
            btnModificarDatos.UseVisualStyleBackColor = true;
            btnModificarDatos.Click += btnModificarDatos_Click;
            // 
            // Form05DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModificarDatos);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(lstDepartamentos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form05DepartamentosEmpleados";
            Text = "Form05DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstDepartamentos;
        private ListBox lstEmpleados;
        private Label label3;
        private Label label4;
        private TextBox txtOficio;
        private TextBox txtSalario;
        private Button btnModificarDatos;
    }
}