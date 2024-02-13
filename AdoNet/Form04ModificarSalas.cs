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
    public partial class Form04ModificarSalas : Form
    {
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04ModificarSalas()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.LoadSalas();
        }

        private void LoadSalas()
        {
            string sql = "select SALA.NOMBRE from SALA GROUP BY SALA.NOMBRE";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstSalas.Items.Clear();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificarSalas_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNuevoNombre.Text;
            string nombreSala = this.lstSalas.Items[this.lstSalas.SelectedIndex].ToString();
            string sql = "update SALA set NOMBRE=@nombre where NOMBRE=@nombreSala";
            SqlParameter pamnombre = new SqlParameter();
            pamnombre.ParameterName = "@nombre";
            pamnombre.DbType = DbType.String;
            pamnombre.Value = nombre;
            pamnombre.Direction = ParameterDirection.Input;

            SqlParameter pamnombresala = new SqlParameter();
            pamnombresala.ParameterName = "@nombreSala";
            pamnombresala.DbType = DbType.String;
            pamnombresala.Value = nombreSala;
            pamnombresala.Direction = ParameterDirection.Input;

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.com.Parameters.Add(pamnombre);
            this.com.Parameters.Add(pamnombresala);
            this.cn.Open();
            com.ExecuteNonQuery();
            this.cn.Close();
            this.LoadSalas();
        }
    }
}
