using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioPropuestos_MVC_CALLE.Models;
namespace EjercicioPropuestos_MVC_CALLE.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index(ClsCajero objcajero)
        {
            if (objcajero.monto_ >= 0)
            {
                objcajero.monto = Convert.ToInt32(Math.Floor(objcajero.monto_));

                objcajero.de100 = objcajero.monto / 100;
                objcajero.de50 = objcajero.monto % 100 / 50;
                objcajero.de20 = objcajero.monto % 100 % 50 / 20;
                objcajero.de10 = objcajero.monto % 100 % 50 % 20 / 10;

                objcajero.cantidad = objcajero.de100 + objcajero.de50 + objcajero.de20 + objcajero.de10;
            }
            else
            {
                Response.Write("<script language=javascript>alert('Ingrese monto correcto.');</script>");
            }
            return View("Index", objcajero);
        }
    }
}