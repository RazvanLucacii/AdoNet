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

#region PROCEDIMIENTOS ALMACENADOS

//create procedure sp_hospitales
//as
//	select * from hospital
//go

//create procedure sp_update_plantilla_hospital
//(@nombrehospital nvarchar(50))
//as
//    declare @codigohospital int
//	select @codigohospital = hospital_cod from hospital
//	where nombre=@nombrehospital
//	update plantilla set salario = salario + 1
//	where hospital_cod=@codigohospital
//	select * from plantilla where hospital_cod=@codigohospital

//go

#endregion

namespace AdoNet
{
    public partial class Form9ProcedimientoUpdatePlantilla : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        public Form9ProcedimientoUpdatePlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = "SP_HOSPITALES";
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            while (this.reader.Read())
            {
                this.cmbHospitales.Items.Add(this.reader["NOMBRE"].ToString());
            }
            this.connection.Close();
        }

        private void btnModificarSalarios_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            SqlParameter pamnombre = new SqlParameter("@NOMBREHOSPITAL", nombre);
            this.command.Parameters.Add(pamnombre);
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = "SP_UPDATE_PLANTILLA_HOSPITAL";
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["FUNCION"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " " + funcion + " " + salario);
            }
            this.reader.Close();
            this.connection.Close();
            this.command.Parameters.Clear();
        }
    }
}
