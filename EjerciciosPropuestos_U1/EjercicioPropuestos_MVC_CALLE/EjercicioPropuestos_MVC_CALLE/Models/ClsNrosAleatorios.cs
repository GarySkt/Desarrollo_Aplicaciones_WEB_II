using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPropuestos_MVC_CALLE.Models
{
    public class ClsNrosAleatorios
    {
        public int cant_numeros { get; set; }
        public int[] numeros { get; set; }
        public int nro_mayor { get; set; }
        public int nro_menor { get; set; }
        public int suma { get; set; }
        public double promedio { get; set; }
    }
}