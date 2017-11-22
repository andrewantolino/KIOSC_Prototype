using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kiosc_Prototype.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int BuildingId { get; set; }
        public string RoomName { get; set; }
        public string RoomDesc { get; set; }

        public Building Building { get; set; }
    }
}