namespace AdoNet
{
    partial class Form07HospitalesClases
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lstHospitales = new ListBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtNumCamas = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(326, 325);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 38);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(326, 281);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 38);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(326, 237);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(134, 38);
            btnInsertar.TabIndex = 21;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(326, 198);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(134, 23);
            txtDireccion.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(326, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(134, 23);
            txtNombre.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Location = new Point(326, 64);
            txtId.Name = "txtId";
            txtId.Size = new Size(134, 23);
            txtId.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 180);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 17;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 112);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 46);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 15;
            label2.Text = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 64);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 14;
            label1.Text = "Hospitales";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.ItemHeight = 15;
            lstHospitales.Location = new Point(63, 88);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(216, 274);
            lstHospitales.TabIndex = 13;
            lstHospitales.SelectedIndexChanged += lstHospitales_SelectedIndexChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(487, 64);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(134, 23);
            txtTelefono.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 46);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 24;
            label5.Text = "Telefono";
            // 
            // txtNumCamas
            // 
            txtNumCamas.Location = new Point(487, 130);
            txtNumCamas.Name = "txtNumCamas";
            txtNumCamas.Size = new Size(134, 23);
            txtNumCamas.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 112);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 26;
            label6.Text = "Num Camas";
            // 
            // Form07HospitalesClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumCamas);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstHospitales);
            Name = "Form07HospitalesClases";
            Text = "Form07HospitalesClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnInsertar;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lstHospitales;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtNumCamas;
        private Label label6;
    }
}