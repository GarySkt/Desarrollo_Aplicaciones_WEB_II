using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio06_MVC_CALLE.Models;

namespace Laboratorio06_MVC_CALLE.Controllers
{
    public class ParImparController : Controller
    {
        // GET: ParImpar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MostrarParesImpares()
        {
            return View();
        }
        public ActionResult CalcularParesImpares(ClsParImpar parimpar)
        {
            return View(parimpar);
        }
    }
}