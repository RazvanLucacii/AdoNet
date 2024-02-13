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
    internal class RepositoryDepartamentos
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public RepositoryDepartamentos()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2023";
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;

        }

        public List<Departamento> GetDepartamentos()
        {
            string sql = "select * from DEPT";
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            List<Departamento> departamentos = new List<Departamento>();
            while (this.reader.Read())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                Departamento dept = new Departamento();
                dept.IdDepartamento = id;
                dept.Nombre = nombre;
                dept.Localidad = loc;
                departamentos.Add(dept);
            }
            this.reader.Close();
            this.connection.Close();
            return departamentos;

        }

        public Departamento FindDepartamento(int idDepartamento)
        {
            string sql = "select * from DEPT where DEPT_NO=@id";
            SqlParameter pamId = new SqlParameter("@id", idDepartamento);
            this.command.Parameters.Add(pamId);
            this.command.CommandText = sql;
            this.command.CommandType = CommandType.Text;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            this.reader.Read();
            int id = int.Parse(this.reader["DEPT_NO"].ToString());
            string nombre = this.reader["DNOMBRE"].ToString();
            string loc = this.reader["LOC"].ToString();
            Departamento departamento = new Departamento();
            departamento.IdDepartamento = id;
            departamento.Nombre = nombre;
            departamento.Localidad = loc;
            this.reader.Close();
            this.command.Parameters.Clear();
            this.connection.Close();
            return departamento;

        }

        public int InsertarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "insert into DEPT values(@id, @nombre, @localidad)";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamLocalidad = new SqlParameter("@localidad", localidad);
            this.command.Parameters.Add(pamId);
            this.command.Parameters.Add(pamNombre);
            this.command.Parameters.Add(pamLocalidad);
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            int results = this.command.ExecuteNonQuery();
            this.connection.Close();
            this.command.Parameters.Clear();
            return results;
        }

        public int ModificarDepartamento(int id, string nombre, string localidad)
        {
            string sql = "update DEPT set DNOMBRE=@nombre, LOC=@localidad " + " where DEPT_NO=@id";
            SqlParameter pamId = new SqlParameter("@id", id);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            SqlParameter pamLocalidad = new SqlParameter("@localidad", localidad);
            this.command.Parameters.Add(pamId);
            this.command.Parameters.Add(pamNombre);
            this.command.Parameters.Add(pamLocalidad);
            this.command.CommandType= CommandType.Text;
            this.command.CommandText = sql;
            this.connection.Open();
            int resultados = this.command.ExecuteNonQuery();
            this.connection.Close();
            this.command.Parameters.Clear();
            return resultados;
        }

        public int EliminarDepartamento(int idDepartamento)
        {
            string sql = "delete from DEPT where DEPT_NO=@iddepartamento";
            SqlParameter pamId = new SqlParameter("@iddepartamento", idDepartamento);
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
