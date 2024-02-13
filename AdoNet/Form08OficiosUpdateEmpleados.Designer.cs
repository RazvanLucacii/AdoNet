namespace AdoNet
{
    partial class Form08OficiosUpdateEmpleados
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
            btnUpdate = new Button();
            txtIncremento = new TextBox();
            label3 = new Label();
            label1 = new Label();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            label4 = new Label();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMinimoSalario = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(565, 157);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 47);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(565, 103);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(134, 23);
            txtIncremento.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 85);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 31;
            label3.Text = "Incremento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 58);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 29;
            label1.Text = "Oficios";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.ItemHeight = 15;
            lstOficios.Location = new Point(60, 85);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(216, 274);
            lstOficios.TabIndex = 28;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(317, 85);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(216, 274);
            lstEmpleados.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(317, 58);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 38;
            label4.Text = "Empleados";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(60, 396);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(87, 15);
            lblSumaSalarial.TabIndex = 39;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(189, 396);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(90, 15);
            lblMediaSalarial.TabIndex = 40;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lblMinimoSalario
            // 
            lblMinimoSalario.AutoSize = true;
            lblMinimoSalario.Location = new Point(317, 396);
            lblMinimoSalario.Name = "lblMinimoSalario";
            lblMinimoSalario.Size = new Size(97, 15);
            lblMinimoSalario.TabIndex = 41;
            lblMinimoSalario.Text = "lblMinimoSalario";
            // 
            // Form08OficiosUpdateEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMinimoSalario);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(label4);
            Controls.Add(lstEmpleados);
            Controls.Add(btnUpdate);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lstOficios);
            Name = "Form08OficiosUpdateEmpleados";
            Text = "Form08OficiosUpdateEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox txtIncremento;
        private Label label3;
        private Label label1;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private Label label4;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMinimoSalario;
    }
}