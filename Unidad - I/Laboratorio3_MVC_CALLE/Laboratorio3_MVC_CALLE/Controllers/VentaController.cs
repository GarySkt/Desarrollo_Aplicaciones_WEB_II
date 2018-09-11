using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3_MVC_CALLE.Models;

namespace Laboratorio3_MVC_CALLE.Controllers
{
    public class VentaController : Controller
    {
        public static double precioUSB = 120; double precioMOUSE = 50;
                        double precioTECLADO = 85;  double precioDISCODURO = 350;

        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularVenta( ClsVenta objVenta)
        {
            //ClsVenta objVenta = new ClsVenta();

            if (objVenta.productoUSB == true )
            {
                objVenta.subtotal = objVenta.subtotal + precioUSB;
            }
            if (objVenta.productoMOUSE == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioMOUSE;
            }
            if (objVenta.productoTECLADO == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioTECLADO;
            }
            if (objVenta.productoDISCODURO == true)
            {
                objVenta.subtotal = objVenta.subtotal + precioDISCODURO;
            }

            objVenta.igv = objVenta.subtotal * 0.18;
            objVenta.total = objVenta.subtotal + objVenta.igv;

            return View("CalcularVenta", objVenta);
        }
    }
}