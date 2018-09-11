using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratiorio1_MVC_CALLE.Models;

namespace Laboratiorio1_MVC_CALLE.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult Index()
        {
            return View();
        }
        //mostrar datos
        public ActionResult MostrarDatos()
        {
            //instanciar clase estudiante
            ClsEstudiante objEstudiante = new ClsEstudiante();
            //instanciar atributos de la clase
            objEstudiante.Apellido = "Calle Cortez";
            objEstudiante.Nombre = "Gary";
            objEstudiante.Edad = 23;
            objEstudiante.Peso = 68.5;

            return View("MostrarDatos",objEstudiante);
        }

    }
}