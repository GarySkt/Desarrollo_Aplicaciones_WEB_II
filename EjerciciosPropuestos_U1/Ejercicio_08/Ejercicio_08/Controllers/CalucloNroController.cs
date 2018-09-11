using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio_08.Models;

namespace Ejercicio_08.Controllers
{
    public class CalucloNroController : Controller
    {
        // GET: CalucloNro
        public ActionResult Index(ClsNroCalculo objnrocalculo)
        {
            if (objnrocalculo.nro == 0)
            {

            }
            else
            {
                ClsNroCalculo.listnros.Add(objnrocalculo.nro);
                foreach(var item in ClsNroCalculo.listnros)
                {
                    ViewData["Resultado"] += Convert.ToString(item) + "\n";
                }
            }

            return View("Index" , objnrocalculo);
        }

        public ActionResult Calcular (ClsNroCalculo objnrocalculo)
        {
            foreach (int item in ClsNroCalculo.listnros)
            {
                objnrocalculo.suma = objnrocalculo.suma + item;

                if(item > objnrocalculo.maxnro)
                {
                    objnrocalculo.maxnro = item;
                }if( objnrocalculo.minnro == 0)
                {
                    objnrocalculo.minnro = item;
                }if(item < objnrocalculo.minnro)
                {
                    objnrocalculo.minnro = item;
                }
            }
            //promedio es igual al resultado de la suma entre la cantidad de la lista (count)
            objnrocalculo.promedio = objnrocalculo.suma / ClsNroCalculo.listnros.Count();   

            return View("Index", objnrocalculo);
        }

        public ActionResult LimpiarLista(ClsNroCalculo objnrocalculo)
        {
            ClsNroCalculo.listnros.Clear();
            return View("Index", objnrocalculo);
        }
    }
}