using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdoNet.Models
{
    internal class EmpleadoHospital
    {
        public int IdEmpleado { get; set; }
        public string Apellido { get; set; }
        public int Salario { get; set; }

        public override string ToString()
        {
            return this.Apellido + " - " + this.Salario;
        }
    }
}
