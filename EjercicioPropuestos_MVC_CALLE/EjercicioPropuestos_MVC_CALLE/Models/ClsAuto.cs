using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPropuestos_MVC_CALLE.Models
{
    public class ClsAuto
    {
        public bool chico { get; set; }
        public bool mediano { get; set; }
        public bool grande { get; set; }
        public int cant_dias { get; set; }
        public int km_recorrido { get; set; }
        public string tipo_auto { get; set; }
        public double total { get; set; }
    }
}