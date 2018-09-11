using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio06_MVC_CALLE.Models;

namespace Laboratorio06_MVC_CALLE.Controllers
{
    public class FacturaController : Controller
    {
        // GET: Factura
        public ActionResult Index(ClsFactura obj)
        {
            if (obj.nombre_producto == "")
            {

            }
            else
            {
                ClsFactura.listproducto.Add(obj.nombre_producto);
                ClsFactura.listprecio_producto.Add(obj.cant_producto);
                ClsFactura.listprecio_producto.Add(obj.precio_unit);    
                foreach (var item in ClsFactura.listproducto)
                {
                    ViewData["Resultado"] += Convert.ToString(item) + "\n";
                }
                foreach (var item in ClsFactura.listprecio_producto)
                {
                    ViewData["Resultado"] += Convert.ToString(item) + "\n";
                }
            }


            return View("Index", obj);
        }
    }
}