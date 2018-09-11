using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPropuestos_MVC_CALLE.Models
{
    public class ClsSubsidio
    {
        public string cant_hijos { get; set; }
        public int hijos_escolaridad { get; set; }

        public bool viuda { get; set; }
        public double resultado { get; set; }
    }
}