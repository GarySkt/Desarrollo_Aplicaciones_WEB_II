using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioPropuestos_MVC_CALLE.Controllers
{
    public class JokeController : Controller
    {
        // GET: Joke
        public ActionResult Index()
        {
            return View();
        }
    }
}