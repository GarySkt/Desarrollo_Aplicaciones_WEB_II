using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio06_MVC_CALLE.Models
{
    public class ClsFactura
    {
        public static List<string> listproducto = new List<string>();
        public static List<double> listprecio_producto = new List<double>();
        public int nro_item { get; set; }
        public string nombre_producto { get; set; }
        public double cant_producto { get; set; }
        public double precio_unit { get; set; }
        public double subtotal { get; set; }
    }
}