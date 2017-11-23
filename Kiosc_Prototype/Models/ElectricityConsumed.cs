using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class ElectricityConsumed
    {
        [Key, Column(Order = 0)]
        public DateTime ReadingTime { get; set; }
        [Key, Column(Order = 1)]
        public int BuildingId { get; set; }
        public int MssbValue { get; set; }
        public int DbkL1Value { get; set; }
        public int DbkL2Value { get; set; }

        public virtual Building Building { get; set; }
    }
}