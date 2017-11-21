using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class ElectricityConsumed
    {
        public DateTime DateTime;
        public int BuildingId;
        public int MSSBValue;
        public int DBK_L1Value;
        public int DBK_L2Value;
    }
}