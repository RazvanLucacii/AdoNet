namespace AdoNet
{
    partial class Form9ProcedimientoUpdatePlantilla
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
            cmbHospitales = new ComboBox();
            btnModificarSalarios = new Button();
            lblPlantilla = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(48, 53);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(121, 23);
            cmbHospitales.TabIndex = 1;
            // 
            // btnModificarSalarios
            // 
            btnModificarSalarios.Location = new Point(282, 52);
            btnModificarSalarios.Name = "btnModificarSalarios";
            btnModificarSalarios.Size = new Size(96, 45);
            btnModificarSalarios.TabIndex = 2;
            btnModificarSalarios.Text = "Modificar Salarios";
            btnModificarSalarios.UseVisualStyleBackColor = true;
            btnModificarSalarios.Click += btnModificarSalarios_Click;
            // 
            // lblPlantilla
            // 
            lblPlantilla.AutoSize = true;
            lblPlantilla.Location = new Point(48, 108);
            lblPlantilla.Name = "lblPlantilla";
            lblPlantilla.Size = new Size(49, 15);
            lblPlantilla.TabIndex = 3;
            lblPlantilla.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.ItemHeight = 15;
            lstPlantilla.Location = new Point(49, 126);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(348, 124);
            lstPlantilla.TabIndex = 4;
            // 
            // Form9ProcedimientoUpdatePlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstPlantilla);
            Controls.Add(lblPlantilla);
            Controls.Add(btnModificarSalarios);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "Form9ProcedimientoUpdatePlantilla";
            Text = "Form9ProcedimientoUpdatePlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbHospitales;
        private Button btnModificarSalarios;
        private Label lblPlantilla;
        private ListBox lstPlantilla;
    }
}