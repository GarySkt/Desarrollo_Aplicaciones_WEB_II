using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio_LINQ_MVC_CALLE.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        String[] meses =
        {
            "Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Setiembre","Octubre","Noviemvre","Diciembre"
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectMany()
        {
            var query = meses.SelectMany(e => e.ToCharArray());

            foreach (char mes in query)
            {
                ViewData["Resultado"] += Convert.ToString(mes) + "\n";
            }
            return View();
        }

        public ActionResult ListarMeses()
        {
            var query = meses.ToList();
            foreach (var mes in query)
            {
                ViewData["Resultado"] += Convert.ToString(mes) + "\n";
            }
            return View();
        }
        public ActionResult Reverse()
        {
            String[] mesesreversa = meses.Reverse().ToArray();
            foreach (var mes in mesesreversa)
            {
                ViewData["Resultado"] += Convert.ToString(mes) + "\n";
            }
            return View();
        }

        public ActionResult where()
        {
            var query = from mes in meses
                        where mes.StartsWith("A")
                        select new { NombreMes = mes };
            foreach(var item in query)
            {
                ViewData["Resultado"] += Convert.ToString(item) + "\n";
            }
            return View();
        }
        public ActionResult where2()
        {
            var query = from mes in meses
                        where mes.ToLowerInvariant().Contains("a")
                        select new { NombreMes = mes };
            foreach (var item in query)
            {
                ViewData["Resultado"] += Convert.ToString(item) + "\n";
            }
            return View();
        }
        public ActionResult where3()
        {
            var query = from mes in meses
                        where mes.Length > 5
                        select new { NombreMes = mes };
            foreach (var item in query)
            {
                ViewData["Resultado"] += Convert.ToString(item) + "\n";
            }
            return View();
        }

    }
}