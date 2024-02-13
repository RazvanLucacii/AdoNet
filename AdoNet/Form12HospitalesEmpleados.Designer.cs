namespace AdoNet
{
    partial class Form12HospitalesEmpleados
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
            txtPersonas = new TextBox();
            txtMedia = new TextBox();
            txtSuma = new TextBox();
            lstEmpleados = new ListBox();
            cmbHospitales = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(519, 81);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(100, 23);
            txtPersonas.TabIndex = 14;
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(391, 81);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 13;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(258, 81);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 12;
            txtSuma.TextChanged += txtSuma_TextChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(75, 141);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(200, 259);
            lstEmpleados.TabIndex = 11;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(75, 81);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(121, 23);
            cmbHospitales.TabIndex = 10;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 53);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 8;
            label1.Text = "Hospitales";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(309, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // Form12HospitalesEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtPersonas);
            Controls.Add(txtMedia);
            Controls.Add(txtSuma);
            Controls.Add(lstEmpleados);
            Controls.Add(cmbHospitales);
            Controls.Add(label1);
            Name = "Form12HospitalesEmpleados";
            Text = "Form12HospitalesEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersonas;
        private TextBox txtMedia;
        private TextBox txtSuma;
        private ListBox lstEmpleados;
        private ComboBox cmbHospitales;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}