using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjercicioPropuestos_MVC_CALLE.Models;

namespace EjercicioPropuestos_MVC_CALLE.Controllers
{
    public class NrosAleatoriosController : Controller
    {
        // GET: NrosAleatorios
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Calcular(ClsNrosAleatorios objnroaleatorio)
        {

            objnroaleatorio.numeros = new int[objnroaleatorio.cant_numeros];
            Random rand = new Random();
            for (int i = 0; i < objnroaleatorio.cant_numeros; i++)
            {
                objnroaleatorio.numeros[i] = rand.Next(1, 1000);
            }
            Array.Sort(objnroaleatorio.numeros);
            objnroaleatorio.nro_mayor = objnroaleatorio.numeros[(objnroaleatorio.cant_numeros - 1)];
            objnroaleatorio.nro_menor = objnroaleatorio.numeros[0];
            objnroaleatorio.suma = objnroaleatorio.numeros.Sum();
            objnroaleatorio.promedio = objnroaleatorio.suma / objnroaleatorio.cant_numeros;
            
            return View("Index", objnroaleatorio);
        }
    }
}