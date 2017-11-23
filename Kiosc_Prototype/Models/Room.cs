using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Room
    {
        [Key, Column(Order = 0)]
        public int RoomId { get; set; }
        public int BuildingId { get; set; }
        public string RoomName { get; set; }
        public string RoomDesc { get; set; }

        public virtual Building Building { get; set; }
    }
}