using AdoNet.Helpers;
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
    internal class RepositoryParametrosSalida
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public RepositoryParametrosSalida() 
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }

        public List<string> GetDepartamentos()
        {
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = "SP_DEPARTAMENTOS";
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            List<string> departamentos = new List<string>();
            while (this.reader.Read())
            {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }
            this.reader.Close();
            this.connection.Close();
            return departamentos;
        }

        public ResumenEmpleados GetResumenEmpleados(string departamentos)
        {
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", departamentos);
            this.command.Parameters.Add(pamNombre);
            SqlParameter pamSuma = new SqlParameter("@SUMA", SqlDbType.Int);
            pamSuma.Direction = ParameterDirection.Output;
            this.command.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter("@MEDIA", SqlDbType.Int);
            pamMedia.Direction = ParameterDirection.Output;
            this.command.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter("@PERSONAS", SqlDbType.Int);
            pamPersonas.Direction = ParameterDirection.Output;
            this.command.Parameters.Add(pamPersonas);
            this.command.CommandText = "SP_EMPLEADOS_DEPARTAMENTOS";
            this.command.CommandType = CommandType.StoredProcedure;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            ResumenEmpleados resumen = new ResumenEmpleados();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                resumen.Apellidos.Add(apellido);
            }
            this.reader.Close();
            int suma = int.Parse(pamSuma.Value.ToString());
            int media = int.Parse(pamMedia.Value.ToString());
            int personas = int.Parse(pamPersonas.Value.ToString());

            resumen.SumaSalarial = suma;
            resumen.MediaSalarial = media;
            resumen.Personas = personas;
            this.connection.Close();
            this.command.Parameters.Clear();
            return resumen;
        }
    }
}
