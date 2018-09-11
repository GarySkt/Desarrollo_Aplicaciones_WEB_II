using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio_12.Controllers
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