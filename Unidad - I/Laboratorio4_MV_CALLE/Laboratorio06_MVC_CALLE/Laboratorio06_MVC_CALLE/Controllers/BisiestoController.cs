using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio06_MVC_CALLE.Models;

namespace Laboratorio06_MVC_CALLE.Controllers
{
    public class BisiestoController : Controller
    {
        // GET: Bisiesto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MostrarAnios()
        {
            return View();
        }
        public ActionResult CalcularAnios(ClsBisiesto eje)
        {
            return View(eje);
        }
    }
}