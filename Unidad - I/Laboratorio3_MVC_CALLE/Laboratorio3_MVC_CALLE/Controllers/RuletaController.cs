using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3_MVC_CALLE.Models;

namespace Laboratorio3_MVC_CALLE.Controllers
{
    public class RuletaController : Controller
    {
        // GET: Ruleta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GenerarRuleta(ClsRuleta objRuleta)
        {

            Random rnd = new Random();
            objRuleta.valor1 = rnd.Next(3);
            objRuleta.valor2 = rnd.Next(3);
            objRuleta.valor3 = rnd.Next(3);

            if (objRuleta.valor1 == objRuleta.valor2 && objRuleta.valor2 == objRuleta.valor3)
            {
                objRuleta.resultado = "Ganaste un pasaje en combi a tu casa";
            }
            else
            {
                objRuleta.resultado = "te vas a patas noma, sigue intentando mi bruh";
            }

            return View("GenerarRuleta", objRuleta);
        }
    }

}