using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Gas
    {
        [Key, Column(Order = 0)]
        public DateTime ReadingTime { get; set; }
        [Key, Column(Order = 1)]
        public int BuildingId { get; set; }
        public int GasValue { get; set; }

        public virtual Building Building { get; set; }

        //public Gas(int buildingId, int gasValue)
        //{
        //    ReadingTime = new DateTime();
        //    BuildingId = buildingId;
        //    GasValue = gasValue;
        //}
    }
}