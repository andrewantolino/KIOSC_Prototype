using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Water
    {
        public DateTime ReadingTime { get; set; }
        public int BuildingId { get; set; }
        public int WaterHot { get; set; }
        public int WaterCold { get; set; }

        public Building Building { get; set; }
    }
}