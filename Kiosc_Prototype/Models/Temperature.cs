using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Temperature
    {
        public DateTime ReadingTime { get; set; }
        public int RoomId { get; set; }
        public int BuildingId { get; set; }
        public double TemperatureValue { get; set; }

        public Room Room { get; set; }
    }
}