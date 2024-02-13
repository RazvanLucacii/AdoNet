using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    internal class Hospitales
    {
        public string HOSPITAL_COD {  get; set; }
        public string NOMBRE {  get; set; }
        public string DIRECCION {  get; set; }
        public string TELEFONO {  get; set; }
        public string NUM_CAMA {  get; set; }

        public override string ToString()
        {
            return this.HOSPITAL_COD + " - " + this.NOMBRE;
        }
    }
}
