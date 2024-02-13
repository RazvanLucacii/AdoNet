using AdoNet.Models;
using AdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form11ParametrosSalida : Form
    {
        RepositoryParametrosSalida repo;
        public Form11ParametrosSalida()
        {
            InitializeComponent();
            repo = new RepositoryParametrosSalida();
            this.LoadDepartamentos();
        }

        private void LoadDepartamentos()
        {
            List<string> departamentos = this.repo.GetDepartamentos();
            foreach (string datos in departamentos)
            {
                this.cmbDepartamentos.Items.Add(datos);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            ResumenEmpleados resumen =
                this.repo.GetResumenEmpleados(nombre);
            this.lstEmpleados.Items.Clear();
            foreach (string datos in resumen.Apellidos)
            {
                this.lstEmpleados.Items.Add(datos);
            }
            this.txtSuma.Text = resumen.SumaSalarial.ToString();
            this.txtMedia.Text = resumen.MediaSalarial.ToString();
            this.txtPersonas.Text = resumen.Personas.ToString();
        }
    }
}
