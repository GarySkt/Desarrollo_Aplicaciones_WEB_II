using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratiorio1_MVC_CALLE.Models;

namespace Laboratiorio1_MVC_CALLE.Controllers
{
    public class SumaController : Controller
    {
        // GET: Suma
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MostrarSuma()
        {
            ClsSuma objSuma = new ClsSuma();
            //recepcionar las variables de un formulario
            objSuma.numero1 = Convert.ToDouble(Request.Form["valor1"]);
            objSuma.numero2 = Convert.ToDouble(Request.Form["valor2"]);

            //operacion
            objSuma.resultado = objSuma.numero1 + objSuma.numero2;
            return View("MostrarSuma", objSuma);
        }
    }
}