using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kiosc_Prototype.DAL;
using Kiosc_Prototype.Models;

namespace Kiosc_Prototype.Controllers
{
    public class VisualizerController : Controller
    {
        // GET: Visualizer
        public ActionResult Visualizer()
        {
            using (var db = new ApplicationDbContext())
            {
                var waterEntry = new Water()
                {
                    Building = new Building(),
                    BuildingId = 1,
                    ReadingTime = new DateTime(2016, 9, 14),
                    WaterCold = 500,
                    WaterHot = 500
                };

                db.Waters.Add(waterEntry);

                db.SaveChanges();

                return View(waterEntry);
            }
        }
    }
}