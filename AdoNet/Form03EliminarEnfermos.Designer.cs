﻿namespace AdoNet
{
    partial class Form03EliminarEnfermos
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
            btnEliminarEnfermo = new Button();
            label1 = new Label();
            txtInscripcion = new TextBox();
            label2 = new Label();
            lstEnfermos = new ListBox();
            SuspendLayout();
            // 
            // btnEliminarEnfermo
            // 
            btnEliminarEnfermo.Location = new Point(72, 97);
            btnEliminarEnfermo.Name = "btnEliminarEnfermo";
            btnEliminarEnfermo.Size = new Size(129, 38);
            btnEliminarEnfermo.TabIndex = 0;
            btnEliminarEnfermo.Text = "Eliminar Enfermo";
            btnEliminarEnfermo.UseVisualStyleBackColor = true;
            btnEliminarEnfermo.Click += btnEliminarEnfermo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 39);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Inscripcion";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(72, 57);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(129, 23);
            txtInscripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 39);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.ItemHeight = 15;
            lstEnfermos.Location = new Point(262, 57);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(156, 229);
            lstEnfermos.TabIndex = 4;
            // 
            // Form03EliminarEnfermos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEnfermos);
            Controls.Add(label2);
            Controls.Add(txtInscripcion);
            Controls.Add(label1);
            Controls.Add(btnEliminarEnfermo);
            Name = "Form03EliminarEnfermos";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarEnfermo;
        private Label label1;
        private TextBox txtInscripcion;
        private Label label2;
        private ListBox lstEnfermos;
    }
}