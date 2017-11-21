using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Temperature
    {
        public DateTime DateTime;
        public int RoomId;
        public int BuildingId;
        public double TemperatureValue;
    }
}