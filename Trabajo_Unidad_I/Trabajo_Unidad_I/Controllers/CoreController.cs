using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Trabajo_Unidad_I.Models;

namespace Trabajo_Unidad_I.Controllers
{
    public class CoreController : Controller
    {
        // GET: Core
        public ActionResult Index(ClsCore obj)
        {            
            obj.parallelStart = DateTime.Now;
            int inputData = 0;

            Parallel.For(0, 1000000000, i =>
            {
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
            });

            obj.parallelFinish = DateTime.Now;
            obj.singeStart = DateTime.Now;

            for (int i = 0; i < 1000000000; i++)
            {
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
                inputData = inputData++;
            }
            obj.singeFinish = DateTime.Now;

            obj.parallel_execution_time = (obj.parallelFinish - obj.parallelStart).Seconds;
            obj.Singe_execution_time = (obj.singeFinish-obj.singeStart).Seconds;
            return View("Index", obj);
        }
    }
}