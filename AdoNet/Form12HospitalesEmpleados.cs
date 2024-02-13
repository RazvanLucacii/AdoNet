using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form12HospitalesEmpleados : Form
    {
        RepositoryHospitalesEmpleados repo;
        public Form12HospitalesEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitalesEmpleados();
            this.LoadHospitales();
        }

        private void LoadHospitales()
        {
            List<string> hospitales = this.repo.GetHospitales();
            foreach (string datos in hospitales)
            {
                this.cmbHospitales.Items.Add(datos);
            }
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpleadoHospital empleado = lstEmpleados.SelectedItem as EmpleadoHospital;

            textBox1.Text = empleado.Apellido;
            textBox2.Text = empleado.Salario.ToString();
        }

        private void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.lstEmpleados.Items.Clear();
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            DatosHospital resumen = this.repo.GetResumenEmpleados(nombre);
            foreach (EmpleadoHospital empleado in resumen.Empleados)
            {
                this.lstEmpleados.Items.Add(empleado);
            }
            this.txtSuma.Text = resumen.SumaSalarial.ToString();
            this.txtMedia.Text = resumen.MediaSalarial.ToString();
            this.txtPersonas.Text = resumen.Personas.ToString();
        }

        private void txtSuma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
