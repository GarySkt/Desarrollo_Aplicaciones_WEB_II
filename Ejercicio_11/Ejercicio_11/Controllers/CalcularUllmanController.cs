using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio_11.Models;

namespace Ejercicio_11.Controllers
{
    public class CalcularUllmanController : Controller
    {
        // GET: CalcularUllman
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularUllman (ClsUllman objUllman)
        {
            //while (objUllman.nro != 1)
            //{
            //    if (objUllman.nro % 2 == 0)
            //    {
            //        objUllman.nro = objUllman.nro / 2;

            //    }
            //    else
            //    {
            //        objUllman.nro = 3 * objUllman.nro + 1;
            //    }
            //}


            return View("CalcularUllman", objUllman);
        }
    }
}