using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio2_MVC_CALLE.Models;

namespace Laboratorio2_MVC_CALLE.Controllers
{
    public class CompraController : Controller
    {
        // GET: Compra
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularCompra(ClsCompra objCompra)
        {
            Random valor = new Random();
            objCompra.random = valor.Next(1, 500);
            return View("CalcularCompra", objCompra);
        }
    }
}