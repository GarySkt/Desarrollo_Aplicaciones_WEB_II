using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPropuestos_MVC_CALLE.Models
{
    public class ClsNroCalculo
    {
        public static List<int> listnros = new List<int>();
        public int nro { get; set; }
        public int maxnro { get; set; }
        public int minnro { get; set; }
        public int suma { get; set; }
        public int promedio { get; set; }
    }
}