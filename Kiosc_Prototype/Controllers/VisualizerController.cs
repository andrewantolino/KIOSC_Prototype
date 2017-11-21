using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kiosc_Prototype.Models;

namespace Kiosc_Prototype.Controllers
{
    public class VisualizerController : Controller
    {
        // GET: Visualizer
        public ActionResult Visualizer()
        {
            var service = new Gas(1, 500);

            return View(service);
        }
    }
}