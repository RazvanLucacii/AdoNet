using AdoNet.Helpers;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region PROCEDURES

//create procedure sp_doctores_plantilla_hospital
//(@nombre nvarchar(50), @suma int out)
//as
//    declare @idhospital int
//	declare @sumadoctores int
//	declare @sumaplantilla int
//	select @idhospital = hospital_cod from hospital
//	where nombre = @nombre
//	select doctor.apellido, doctor.salario 
//	from doctor where hospital_cod = @idhospital
//	union
//	select apellido, salario from plantilla where hospital_cod=@idhospital
//	select @sumadoctores = sum(doctor.salario) from doctor

//    where hospital_cod = @idhospital
//                                               select @sumaplantilla = sum(plantilla.salario) from plantilla
                                           
//    where hospital_cod = @idhospital

//    set @suma = @sumadoctores + @sumaplantilla
//go

//declare @resultado int
//exec sp_doctores_plantilla_hospital 'ruber', @resultado output
//print @resultado

//create view v_doctores_plantilla
//as
//	select doctor_no as idempleado, apellido, doctor.salario, doctor.hospital_cod 
//	from doctor 
//	union
//	select empleado_no, apellido, salario, hospital_cod from plantilla 
//go

//alter procedure sp_doctores_plantilla_hospital
//(@nombre nvarchar(50)
//, @suma int out, @media int out, @personas int out)
//as
//    declare @idhospital int
//	select @idhospital = hospital_cod from hospital
//	where nombre = @nombre
//	select * from v_doctores_plantilla
//	where hospital_cod=@idhospital
//	select @suma = sum(salario), @media = avg(salario), 
//	@personas = count(idempleado)

//    from v_doctores_plantilla

//    where hospital_cod = @idhospital
//go

#endregion

namespace AdoNet.Repositories
{
    internal class RepositoryHospitalesEmpleados
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public RepositoryHospitalesEmpleados()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.Connection = this.connection;
        }

        public List<string> GetHospitales()
        {
            this.command.CommandType = CommandType.StoredProcedure;
            this.command.CommandText = "SP_HOSPITALES";
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            List<string> hospitales = new List<string>();
            while (this.reader.Read())
            {
                hospitales.Add(this.reader["NOMBRE"].ToString());
            }
            this.reader.Close();
            this.connection.Close();
            return hospitales;
        }

        public DatosHospital GetResumenEmpleados(string nombreHospital)
        {   
            DatosHospital hospital = new DatosHospital();
            SqlParameter pamNombre = new SqlParameter("@NOMBRE", nombreHospital);
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
            this.command.CommandText = "SP_DOCTORES_PLANTILLA_HOSPITAL";
            this.command.CommandType = CommandType.StoredProcedure;
            this.connection.Open();
            this.reader = this.command.ExecuteReader();
            List<EmpleadoHospital> empleados = new List<EmpleadoHospital>();
            while (this.reader.Read())
            {
                EmpleadoHospital empleado = new EmpleadoHospital();                
                empleado.IdEmpleado = int.Parse(this.reader["IDEMPLEADO"].ToString());
                empleado.Apellido = this.reader["APELLIDO"].ToString();
                empleado.Salario = int.Parse(this.reader["SALARIO"].ToString());
                empleados.Add(empleado);
            }
            this.reader.Close();
            int suma = int.Parse(pamSuma.Value.ToString());
            int media = int.Parse(pamMedia.Value.ToString());
            int personas = int.Parse(pamPersonas.Value.ToString());

            hospital.Empleados = empleados;
            hospital.SumaSalarial = suma;
            hospital.MediaSalarial = media;
            hospital.Personas = personas;
            this.connection.Close();
            this.command.Parameters.Clear();
            return hospital;
        }
    }
}
