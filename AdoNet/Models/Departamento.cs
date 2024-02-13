﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    internal class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }

        public override string ToString()
        {
            return this.IdDepartamento.ToString() + " - " + this.Nombre + " - " + this.Localidad;
        }

    }
}
