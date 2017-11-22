using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class ElectricityConsumed
    {
        public DateTime ReadingTime { get; set; }
        public int BuildingId { get; set; }
        public int MssbValue { get; set; }
        public int DbkL1Value { get; set; }
        public int DbkL2Value { get; set; }

        public Building Building { get; set; }
    }
}