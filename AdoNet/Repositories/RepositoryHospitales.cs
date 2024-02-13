using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Repositories
{
    internal class RepositoryHospitales
    {
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }

        public List<Hospitales> GetHospitales()
        {
            string sql = "select * from HOSPITAL";
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            List<Hospitales> hospitales = new List<Hospitales>();
            while (this.reader.Read()) 
            { 
                string id = this.reader["HOSPITAL_COD"].ToString();
                string nombre = this.reader["NOMBRE"].ToString();
                string direccion = this.reader["DIRECCION"].ToString();
                string telefono = this.reader["TELEFONO"].ToString();
                string numeroCamas = this.reader["NUM_CAMA"].ToString();
                Hospitales hosp = new Hospitales();
                hosp.HOSPITAL_COD = id;
                hosp.NOMBRE = nombre;
                hosp.DIRECCION = direccion;
                hosp.TELEFONO = telefono;
                hosp.NUM_CAMA = numeroCamas;
                hospitales.Add(hosp);
            }
            this.reader.Close();
            this.connection.Close();
            return hospitales;
        }

        public Hospitales FindHospitales(string idHospital)
        {
            string sql = "select * from HOSPITAL where HOSPITAL_COD=@id";
            SqlParameter pamId = new SqlParameter("@id", idHospital);
            this.command.Parameters.Add(pamId);
            this.command.CommandText = sql;
            this.command.CommandType = CommandType.Text;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            this.reader.Read();
            string id = this.reader["HOSPITAL_COD"].ToString();
            string nombre = this.reader["NOMBRE"].ToString();
            string direccion = this.reader["DIRECCION"].ToString();
            string telefono = this.reader["TELEFONO"].ToString();
            string numeroCamas = this.reader["NUM_CAMA"].ToString();
            Hospitales hospitales = new Hospitales();
            hospitales.HOSPITAL_COD = id;
            hospitales.NOMBRE = nombre;
            hospitales.DIRECCION = direccion;
            hospitales.TELEFONO = telefono;
            hospitales.NUM_CAMA = numeroCamas;
            this.reader.Close();
            this.command.Parameters.Clear();
            this.connection.Close();
            return hospitales;
        }

        public int InsertarHospital(string id, string nombre, string direccion, string telefono, string numeroCamas)
        {
            string sql = "insert into HOSPITAL values(@id, @nombre, @direccion, @telefono, @numeroCamas)";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelefono = new SqlParameter("@telefono", telefono);
            SqlParameter pamNumeroCamas = new SqlParameter("@numeroCamas", numeroCamas);
            this.command.Parameters.Add(pamId);
            this.command.Parameters.Add(pamNombre);
            this.command.Parameters.Add(pamDireccion);
            this.command.Parameters.Add(pamTelefono);
            this.command.Parameters.Add(pamNumeroCamas);
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            int results = this.command.ExecuteNonQuery();
            this.connection.Close();
            this.command.Parameters.Clear();
            return results;
        }

        public int ModificarHospital(string id, string nombre, string direccion, string telefono, string numeroCamas)
        {
            string sql = "update HOSPITAL set NOMBRE=@nombre, DIRECCION=@direccion, TELEFONO=@telefono, NUM_CAMA=@numeroCamas " + " where HOSPITAL_COD=@id";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            SqlParameter pamTelefono = new SqlParameter("@telefono", telefono);
            SqlParameter pamNumeroCamas = new SqlParameter("@numeroCamas", numeroCamas);
            this.command.Parameters.Add(pamId);
            this.command.Parameters.Add(pamNombre);
            this.command.Parameters.Add(pamDireccion);
            this.command.Parameters.Add(pamTelefono);
            this.command.Parameters.Add(pamNumeroCamas);
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            int resultados = this.command.ExecuteNonQuery();
            this.connection.Close();
            this.command.Parameters.Clear();
            return resultados;
        }

        public int EliminarHospital(string idHospital)
        {
            string sql = "delete from HOSPITAL where HOSPITAL_COD=@idhospital";
            SqlParameter pamId = new SqlParameter("@idhospital", idHospital);
            this.command.Parameters.Add(pamId);
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            int deleted = this.command.ExecuteNonQuery();
            this.connection.Close();
            this.command.Parameters.Clear();
            return deleted;
        }
    }
}
