using AdoNet.Helpers;
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

#region



#endregion
namespace AdoNet
{
    public partial class Form10MensajesServidor : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public Form10MensajesServidor()
        {
            InitializeComponent();
            string connectionString = HelperConfiguration.GetConnectionString();
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
            this.connection.InfoMessage += Cn_InfoMessage;
            this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensajes.Text = e.Message;
        }

        private void LoadDepartamentos()
        {
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = "SP_DEPARTAMENTOS";
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            while (this.reader.Read())
            {
                string num = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(num + " - " + nombre + " - " + localidad);
            }
            this.connection.Close();
            this.reader.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMensajes.Text = "";
            int id = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            SqlParameter pamId = new SqlParameter("@IDDEPARTAMENTO", id);
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombre);
            SqlParameter pamLocalidad = new SqlParameter("@LOCALIDAD", localidad);
            this.command.Parameters.Add(pamId);
            this.command.Parameters.Add(pamNombre);
            this.command.Parameters.Add(pamLocalidad);
            this.command.CommandText = "SP_INSERT_DEPARTAMENTO";
            this.lstDepartamentos.Items.Clear();
            this.command.CommandType = CommandType.StoredProcedure;
            this.connection.Open();
            int insertados = this.command.ExecuteNonQuery();
            this.connection.Close();
            this.command.Parameters.Clear();
            MessageBox.Show("Departamentos insertados: " + insertados);
            this.LoadDepartamentos();
        }
    }
}
