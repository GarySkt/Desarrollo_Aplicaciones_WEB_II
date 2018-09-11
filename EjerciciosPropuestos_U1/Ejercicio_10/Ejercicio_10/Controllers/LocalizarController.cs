using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio_10.Models;

namespace Ejercicio_10.Controllers
{
    public class LocalizarController : Controller
    {
        // GET: Localizar
        public double x; double y;
        string resultado;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Localizar (ClsBrujula objBrujula)
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
            }else
            {
                objBrujula.resultado = "ORIGEN";
            }
            
            return View("Localizar", objBrujula);
        }
    }
}