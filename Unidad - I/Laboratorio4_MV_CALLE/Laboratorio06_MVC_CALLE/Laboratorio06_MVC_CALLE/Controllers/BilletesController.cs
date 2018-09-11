using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio06_MVC_CALLE.Models;
namespace Laboratorio06_MVC_CALLE.Controllers
{
    public class BilletesController : Controller
    {
        // GET: Billetes
        public ActionResult Index(ClsBilletes billetes)
        {
            int cantidadTotal;
            cantidadTotal = billetes.monto;

            int cant100, cant50, cant20, cant10;
            int res100, res50, res20, res10;

            cant100 = cantidadTotal / 100;
            res100 = cantidadTotal % 100;

            cant50 = cantidadTotal / 50;
            res50 = cantidadTotal % 50;

            cant20 = cantidadTotal / 20;
            res20 = cantidadTotal % 20;

            cant10 = cantidadTotal / 10;
            res10 = cantidadTotal % 10;


            billetes.b100 = cant100;
            billetes.b50 = cant50;
            billetes.b20 = cant20;
            billetes.b10 = cant10;
            return View("Index", billetes);
        }
    }
}