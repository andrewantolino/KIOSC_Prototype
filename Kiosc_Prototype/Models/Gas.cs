using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Gas
    {
        public DateTime ReadingTime { get; set; }
        public int BuildingId { get; set; }
        public int GasValue { get; set; }

        public Building Building { get; set; }

        public Gas(int buildingId, int gasValue)
        {
            ReadingTime = new DateTime();
            BuildingId = buildingId;
            GasValue = gasValue;
        }
    }
}