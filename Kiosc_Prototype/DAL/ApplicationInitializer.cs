using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Kiosc_Prototype.Models;

namespace Kiosc_Prototype.DAL
{
    public class ApplicationInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var gas = new List<Gas>
            {
                new Gas {Building = new Building(), BuildingId = 1, GasValue = 500, ReadingTime = new DateTime()},
                new Gas {Building = new Building(), BuildingId = 1, GasValue = 356, ReadingTime = new DateTime()},
                new Gas {Building = new Building(), BuildingId = 1, GasValue = 1002, ReadingTime = new DateTime()}
            };

            gas.ForEach(r => context.Gass.Add(r));
            context.SaveChanges();

            var water = new List<Water>
            {
                new Water {Building = new Building(), BuildingId = 1, WaterCold = 500, WaterHot = 150, ReadingTime = new DateTime()},
                new Water {Building = new Building(), BuildingId = 1, WaterCold = 62, WaterHot = 322, ReadingTime = new DateTime()},
                new Water {Building = new Building(), BuildingId = 1, WaterCold = 1500, WaterHot = 1150, ReadingTime = new DateTime()}
            };

            water.ForEach(r => context.Waters.Add(r));
            context.SaveChanges();

            var elecProduced = new List<ElectricityProduced>
            {
                new ElectricityProduced{Building = new Building(), BuildingId = 1, ProducedValue = 2500, ReadingTime = new DateTime()},
                new ElectricityProduced{Building = new Building(), BuildingId = 1, ProducedValue = 40213, ReadingTime = new DateTime()},
                new ElectricityProduced{Building = new Building(), BuildingId = 1, ProducedValue = 6221, ReadingTime = new DateTime()}
            };

            elecProduced.ForEach(r => context.ElectricityProduceds.Add(r));
            context.SaveChanges();

            var elecConsumed = new List<ElectricityConsumed>
            {
                new ElectricityConsumed{Building = new Building(), BuildingId = 1, MssbValue = 713, DbkL1Value = 200, DbkL2Value = 176, ReadingTime = new DateTime()},
                new ElectricityConsumed{Building = new Building(), BuildingId = 1, MssbValue = 651, DbkL1Value = 132, DbkL2Value = 2315, ReadingTime = new DateTime()},
                new ElectricityConsumed{Building = new Building(), BuildingId = 1, MssbValue = 3002, DbkL1Value = 6999, DbkL2Value = 468, ReadingTime = new DateTime()}
            };

            elecConsumed.ForEach(r => context.ElectricityConsumeds.Add(r));
            context.SaveChanges();

            var temperature = new List<Temperature>
            {
                new Temperature{ Room = new Room(), BuildingId = 1, RoomId = 2, TemperatureValue = 21.2, ReadingTime = new DateTime()},
                new Temperature{ Room = new Room(), BuildingId = 1, RoomId = 16, TemperatureValue = 18.7, ReadingTime = new DateTime()},
                new Temperature{ Room = new Room(), BuildingId = 1, RoomId = 8, TemperatureValue = 22.0, ReadingTime = new DateTime()},
            };

            temperature.ForEach(r => context.Temperatures.Add(r));
            context.SaveChanges();

            var room = new List<Room>
            {
                new Room{ Building = new Building(), BuildingId = 1, RoomDesc = "Corridor level 1 KIOSC building", RoomId = 1, RoomName = "Level 1 Corridor"},
                new Room{ Building = new Building(), BuildingId = 1, RoomDesc = "Room for test purposes", RoomId = 1, RoomName = "Test Room"},
                new Room{ Building = new Building(), BuildingId = 1, RoomDesc = "Science Room first level", RoomId = 1, RoomName = "Science Room 1"}
            };

            room.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();

            var building = new List<Building>
            {
                new Building{ BuildingId = 1, BuildingName = "KIOSC Building", BuildingDesc = "Building of the KIOSC department"},
                new Building{ BuildingId = 1, BuildingName = "Test Building", BuildingDesc = "Building for test purposes"}
            };

            building.ForEach(r => context.Buildings.Add(r));
        }
    }
}