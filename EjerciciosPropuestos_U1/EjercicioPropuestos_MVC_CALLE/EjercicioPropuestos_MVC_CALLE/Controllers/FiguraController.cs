using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioPropuestos_MVC_CALLE.Models;

namespace EjercicioPropuestos_MVC_CALLE.Controllers
{
    public class FiguraController : Controller
    {
        // GET: Figura
        public ActionResult Index(ClsFigura objfigura)
        {
            string car = objfigura.caracter.ToString();
            int filas = objfigura.nro_filas;
            string espacio = "";
            objfigura.figura = new string[filas];
            if (objfigura.alineacion == 1)
            {
                for (int i = 0; i < filas; i++)
                {
                    if (i > 0)
                    {
                        objfigura.figura[i] = objfigura.figura[i - 1] + car;
                    }
                    else
                    {
                        objfigura.figura[i] = car;
                    }
                }
            }
            else if (objfigura.alineacion == 2)
            {
                for (int i = 0; i < objfigura.nro_filas; i++)
                {
                    objfigura.figura[i] = objfigura.figura[i] + espacio;
                    for (int j = (filas * 2) - 1; j > 0; j--)
                    {
                        objfigura.figura[i] = objfigura.figura[i] + car;
                    }
                    espacio = espacio + " ";
                    filas = filas - 1;
                }
                Array.Reverse(objfigura.figura);
            }
            else if (objfigura.alineacion == 3)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = filas; j > 0; j--)
                    {
                        if (i >= (j - 1))
                        {
                            objfigura.figura[i] = objfigura.figura[i] + car;
                        }
                        else
                        {
                            objfigura.figura[i] = objfigura.figura[i] + " ";
                        }
                    }
                }
            }

            return View("Index" , objfigura);
        }
    }
}