using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabajo_Unidad_I.Models
{
    public class ClsConcurso
    {
        public static List<String> listcategoria = new List<String>();
        public static List<String> listtema = new List<String>();
        public static List<String> listgrupo = new List<String>();
        public static List<String> listparticpantes = new List<String>();
        public int[] arraynumeros { get; set; }
        public String categoria { get; set; }
        public String tema { get; set; }
    }
}