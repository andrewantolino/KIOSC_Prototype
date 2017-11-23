using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Building
    {
        [Key, Column(Order = 0)]
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public string BuildingDesc { get; set; }
    }
}