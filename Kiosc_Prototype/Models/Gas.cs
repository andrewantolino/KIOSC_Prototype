using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Gas
    {
        public DateTime DateTime;
        public int BuildingId;
        public int GasValue;

        public Gas(int buildingId, int gasValue)
        {
            DateTime = new DateTime();
            BuildingId = buildingId;
            GasValue = gasValue;
        }
    }
}