using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Kiosc_Prototype.Models;

namespace Kiosc_Prototype.DAL
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("Visualizer Context")
        {
            
        }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Gas> Gass { get; set; }
        public DbSet<Water> Waters { get; set; }
        public DbSet<ElectricityConsumed> ElectricityConsumeds { get; set; }
        public DbSet<ElectricityProduced> ElectricityProdcueds { get; set; }
        public DbSet<Temperature> Temperatures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}