using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio_06.Models;

namespace Laboratorio_06.Controllers
{
    
    public class CalcularController : Controller
    {
        public static double autochico = 15; double automediano = 20; double autogrande = 30;
        // GET: Calcular
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularAlquiler (ClsAuto objAuto)
        {
            if(objAuto.tipo_auto == "Chico")
            {
                objAuto.total = (autochico * objAuto.cant_dias) + (objAuto.km_recorrido * 20);
            }
            if (objAuto.tipo_auto == "Mediano")
            {
                objAuto.total = (automediano * objAuto.cant_dias) + (objAuto.km_recorrido * 30);
            }
            if (objAuto.tipo_auto == "Grande")
            {
                objAuto.total = (autogrande * objAuto.cant_dias) + (objAuto.km_recorrido * 40);
            }

            return View(objAuto);
        }
        public ActionResult EnviarDatos()
        {
            return View();
        }
    }
}