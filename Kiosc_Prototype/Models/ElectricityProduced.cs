using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class ElectricityProduced
    {
        public DateTime ReadingTime { get; set; }
        public int BuildingId { get; set; }
        public int ProducedValue { get; set; }

        public Building Building { get; set; }
    }
}