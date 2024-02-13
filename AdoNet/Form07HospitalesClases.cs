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
    public partial class Form07HospitalesClases : Form
    {
        private RepositoryHospitales repoHosp;
        private List<string> idsHospitalesList;
        public Form07HospitalesClases()
        {
            InitializeComponent();
            this.repoHosp = new RepositoryHospitales();
            this.idsHospitalesList = new List<string>();
            this.LoadHospitales();
        }

        public void LoadHospitales()
        {
            List<Hospitales> hospitales = this.repoHosp.GetHospitales();
            this.lstHospitales.Items.Clear();
            this.idsHospitalesList.Clear();
            foreach (Hospitales hosp in hospitales)
            {
                this.idsHospitalesList.Add(hosp.HOSPITAL_COD);
                this.lstHospitales.Items.Add(hosp);
            }
        }
        private void lstHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstHospitales.SelectedIndex;
            if (index != -1)
            {
                string idHospitales = this.idsHospitalesList[index];
                Hospitales hospitales = this.repoHosp.FindHospitales(idHospitales);
                this.txtId.Text = hospitales.HOSPITAL_COD;
                this.txtNombre.Text = hospitales.NOMBRE;
                this.txtDireccion.Text = hospitales.DIRECCION;
                this.txtTelefono.Text = hospitales.TELEFONO;
                this.txtNumCamas.Text = hospitales.NUM_CAMA;

            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            string numeroCamas = this.txtNumCamas.Text;
            int insertados = this.repoHosp.InsertarHospital(id, nombre, direccion, telefono, numeroCamas);
            this.LoadHospitales();
            MessageBox.Show("Hospitales insertados " + insertados);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string idHospitales = this.txtId.Text;
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            string numeroCamas = this.txtNumCamas.Text;
            int resultados = this.repoHosp.ModificarHospital(idHospitales, nombre, direccion, telefono, numeroCamas);
            this.LoadHospitales();
            MessageBox.Show("Hospitales modificados " + resultados);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstHospitales.SelectedIndex;
            if (index != -1)
            {
                string idHospitales = this.idsHospitalesList[index];
                int results = this.repoHosp.EliminarHospital(idHospitales);
                this.LoadHospitales();
                MessageBox.Show("Eliminados: " + results);
            }
        }

    }
}
