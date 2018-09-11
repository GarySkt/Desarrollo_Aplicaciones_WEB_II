using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioPropuestos_MVC_CALLE.Models;

namespace EjercicioPropuestos_MVC_CALLE.Controllers
{
    public class ListarPosNegController : Controller
    {
        // GET: ListarPosNeg
        
        public ActionResult Calcular (ClsPositivoNegativo objposneg)
        {
            int contador1 = 0, contador2 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (objposneg.arraynumero[i] < 0)

                {
                    contador1++;
                }
                else
                {
                    contador2++;
                }
            }

            objposneg.arraynegativos = new int[contador1];
            objposneg.arraypositivos = new int[contador2];
            contador1 = 0;
            contador2 = 0;

            for (int i = 0; i < 10; i++)
            {
                if (objposneg != null)
                {
                    if (objposneg.arraynumero[i] < 0)
                    {
                        objposneg.arraynegativos[contador1] = objposneg.arraynumero[i];
                        contador1++;
                    }
                    else
                    {
                        objposneg.arraypositivos[contador2] = objposneg.arraynumero[i];
                        contador2++;
                    }
                }
            }
            return View("Index", objposneg);
        }
        public ActionResult Index()
        {

            return View();
        }
    }
}