using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kiosc_Prototype.Models;
using System.Data.SqlClient;

namespace Kiosc_Prototype.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult DataDisplay()
        {
            KioscdbEntities display = new KioscdbEntities();
            var d = display.data.ToList();

            ViewBag.Data = d;
            return View();
            
        }
    }
}