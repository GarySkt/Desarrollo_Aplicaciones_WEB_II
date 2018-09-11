using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio_05.Models;

namespace Ejercicio_05.Controllers
{
    public class SubsidioController : Controller
    {
        // GET: Subsidio
        public static double viuda = 20;

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularSubsidio(ClsSubsidio objsubsidio)
        {
            if (objsubsidio.cant_hijos == "0 - 2")
            {
                objsubsidio.resultado = 70 + (objsubsidio.hijos_escolaridad * 10);
            }
            if(objsubsidio.cant_hijos == "3 - 5")
            {
                objsubsidio.resultado = 90 + (objsubsidio.hijos_escolaridad * 10);
            }
            if (objsubsidio.cant_hijos == "+ 6")
            {
                objsubsidio.resultado = 120 + (objsubsidio.hijos_escolaridad * 10);
            }
            if (objsubsidio.viuda == true)
            {
                objsubsidio.resultado = objsubsidio.resultado + viuda;
            }

            

            return View(objsubsidio);
        }
        public ActionResult EnviarDatos(ClsSubsidio objsubsidio)
        {
            return View();
        }
    }
}