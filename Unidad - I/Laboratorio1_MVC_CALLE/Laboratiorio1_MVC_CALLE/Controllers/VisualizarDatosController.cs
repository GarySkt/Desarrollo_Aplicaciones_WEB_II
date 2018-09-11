using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratiorio1_MVC_CALLE.Controllers
{
    public class VisualizarDatosController : Controller
    {
        // GET: VisualizarDatos
        public ActionResult Index()
        {
            return View();
        }
        //crear accion mostrar datos
        public ActionResult MostrarDatos()
        {
            ViewBag.Curso = "Desarrollo de Aplicaciones Web II";
            ViewBag.Nombre = "Gary Calle Cortez";

            ViewData["Carrera"] = "Ingenieria de Sistemas";
            ViewData["FechaHora"] = DateTime.Now.ToString();

            return View();
        }
    }
}