using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioPropuestos_MVC_CALLE.Models;

namespace EjercicioPropuestos_MVC_CALLE.Controllers
{
    public class MediaNrosController : Controller
    {
        // GET: MediaNros
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularMedia(ClsMediaNros objmedianros)
        {

            int con1 = 0, con2 = 0, con11 = 0, con21 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (objmedianros.arraynumeros[i] % 2 == 0)
                {
                    con11++;
                }
                else
                {
                    con21++;
                }
            }
            if (con21 == 0)
            {
                con21 = 1;
            }
            if (con11 == 0)
            {
                con11 = 1;
            }

            objmedianros.arraypares = new int[con11];
            objmedianros.arrayimpares = new int[con21];

            for (int i = 0; i < 10; i++)
            {
                if (objmedianros != null)
                {
                    if (objmedianros.arraynumeros[i] % 2 == 0)
                    {
                        objmedianros.arraypares[con1] = objmedianros.arraynumeros[i];
                        con1++;
                    }
                    else
                    {
                        objmedianros.arrayimpares[con2] = objmedianros.arraynumeros[i];
                        con2++;
                    }
                }
            }

            objmedianros.mediapares = objmedianros.arraypares.Sum() / con11;
            objmedianros.mediaimpares = objmedianros.arrayimpares.Sum() / con21;


            return View("Index", objmedianros);
        }
    }
}