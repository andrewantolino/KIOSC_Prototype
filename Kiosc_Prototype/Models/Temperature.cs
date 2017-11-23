﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Temperature
    {
        [Key, Column(Order = 0)]
        public DateTime ReadingTime { get; set; }
        [Key, Column(Order = 1)]
        public int RoomId { get; set; }
        public int BuildingId { get; set; }
        public double TemperatureValue { get; set; }

        public virtual Room Room { get; set; }
    }
}