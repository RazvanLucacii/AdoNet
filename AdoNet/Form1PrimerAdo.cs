using AdoNet.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace AdoNet
{
    public partial class Form1PrimerAdo : Form
    {
        string connectionString = string.Empty;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public Form1PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = HelperConfiguration.GetConnectionString();
            this.connection = new SqlConnection(this.connectionString);
            this.connection.StateChange += Cn_StageChange;
            this.command = new SqlCommand();
        }

        private void Cn_StageChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexion esta pasando de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.connection.State == ConnectionState.Closed)
                {
                    this.connection.Open();
                }
                this.lblMensaje.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                this.lblMensaje.Text = "Excepcion SQL " + ex.ToString();
                this.lblMensaje.BackColor = Color.Red;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.connection.Close();
            this.lblMensaje.BackColor = Color.Red;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            this.command.Connection = this.connection;
            string sql = "select * from EMP";
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.reader = this.command.ExecuteReader();
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(0);
                string tipoDato = this.reader.GetDataTypeName(0);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipoDato);
            }
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            this.reader.Close();
        }
    }
}