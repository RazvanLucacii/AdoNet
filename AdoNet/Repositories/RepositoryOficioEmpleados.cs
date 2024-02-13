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
    internal class RepositoryOficioEmpleados
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public RepositoryOficioEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }

        public List<string> GetOficios()
        {
            string sql = "select distinct OFICIO from EMP";
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            List<string> oficios = new List<string>();
            while (this.reader.Read())
            {
                oficios.Add(this.reader["OFICIO"].ToString());
            }
            this.reader.Close();
            this.connection.Close();
            return oficios;
        }

        public int GetSumaSalarialOficios(string oficio)
        {
            string sql = "select SUM(SALARIO) as SUMASALARIAL, "
                + " OFICIO from EMP "
                + " group by OFICIO having OFICIO=@OFICIO";
            SqlParameter pamOficio = new SqlParameter("@OFICIO", oficio);
            this.command.Parameters.Add(pamOficio);
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            this.reader.Read();
            int sumaSalarial = int.Parse(this.reader["SUMASALARIAL"].ToString());
            this.reader.Close();
            this.command.Parameters.Clear();
            this.connection.Close();
            return sumaSalarial;
        }

        public List<string> GetEmpleadosOficio(string oficio)
        {
            string sql = "select * from EMP where OFICIO=@oficio";
            SqlParameter pamOficio = new SqlParameter("@oficio", oficio);
            this.command.Parameters.Add(pamOficio);
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            List<string> apellidos = new List<string>();
            while (this.reader.Read())
            {
                apellidos.Add(this.reader["APELLIDO"].ToString());
            }
            this.reader.Close();
            this.command.Parameters.Clear();
            this.connection.Close();
            return apellidos;
        }

        public DatoEmpleadosOficio
            GetDatosEmpleadosOficio(string oficio)
        {
            string sql = "select SUM(SALARIO) as SUMASALARIAL, " +
                " AVG(SALARIO) as MEDIASALARIAL," +
                " MIN(SALARIO) as MINIMOSALARIO, " +
                " OFICIO from EMP " +
                " GROUP BY OFICIO having OFICIO=@OFICIO";
            SqlParameter pamOficio = new SqlParameter("@OFICIO", oficio);
            this.command.Parameters.Add(pamOficio);
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            this.reader.Read();
            int sumaSalarial = int.Parse(this.reader["SUMASALARIAL"].ToString());
            int mediaSalarial = int.Parse(this.reader["MEDIASALARIAL"].ToString());
            int minimoSalario = int.Parse(this.reader["MINIMOSALARIO"].ToString());
            DatoEmpleadosOficio datos = new DatoEmpleadosOficio();
            datos.SumaSalarial= sumaSalarial;
            datos.MediaSalarial= mediaSalarial;
            datos.MinimoSalario= minimoSalario;
            this.reader.Close();
            this.command.Parameters.Clear();
            this.connection.Close();
            return datos;
        }

        public int IncrementarSalarioOficio(string oficio, int incremento)
        {
            string sql = "update EMP set SALARIO=SALARIO + @incremento " + " where OFICIO=@oficio";
            SqlParameter pamIncremento = new SqlParameter("@incremento", incremento);
            SqlParameter pamOficio = new SqlParameter("@oficio", oficio);
            this.command.Parameters.Add(pamOficio);
            this.command.Parameters.Add(pamIncremento);
            this.command.CommandText = sql;
            this.command.CommandType = CommandType.Text;
            this.connection.Open();
            int results = this.command.ExecuteNonQuery();
            this.connection.Close();
            this.command.Parameters.Clear();
            return results;
        }
    }
}
