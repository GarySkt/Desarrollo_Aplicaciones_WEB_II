using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio2_MVC_CALLE.Models;

namespace Laboratorio2_MVC_CALLE.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularOperaciones(ClsOperaciones objOperaciones)
        {
            if (objOperaciones.tipo == "S")
            {
                objOperaciones.resultado = objOperaciones.a + objOperaciones.b;
            }
            else if (objOperaciones.tipo == "R")
            {
                objOperaciones.resultado = objOperaciones.a - objOperaciones.b;
            }
            else if (objOperaciones.tipo == "M")
            {
                objOperaciones.resultado = objOperaciones.a * objOperaciones.b;
            }
            else
            {
                if (objOperaciones.b != 0)
                {
                    objOperaciones.resultado = objOperaciones.a / objOperaciones.b;
                }
            }
            return View(objOperaciones);
        }

        public ActionResult EnviarOperaciones()
        {
            return View();
        }
    }
}