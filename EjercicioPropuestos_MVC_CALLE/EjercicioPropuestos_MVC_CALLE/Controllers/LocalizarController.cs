using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioPropuestos_MVC_CALLE.Models;

namespace EjercicioPropuestos_MVC_CALLE.Controllers
{
    public class LocalizarController : Controller
    {
        // GET: Localizar
        public ActionResult Index(ClsBrujula objBrujula)
        {

            if (objBrujula.x > 0 && objBrujula.y > 0)
            {
                objBrujula.resultado = "Norte";
            }
            else if (objBrujula.x > 0 && objBrujula.y < 0)
            {
                objBrujula.resultado = "Sur";
            }
            else if (objBrujula.x < 0 && objBrujula.y < 0)
            {
                objBrujula.resultado = "Este";
            }
            else if (objBrujula.x < 0 && objBrujula.y > 0)
            {
                objBrujula.resultado = "Oeste";
            }
            else
            {
                objBrujula.resultado = "ORIGEN";
            }
            return View("Index", objBrujula);
        }
    }
}