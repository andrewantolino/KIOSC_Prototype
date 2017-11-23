namespace Kiosc_Prototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Building",
                c => new
                    {
                        BuildingId = c.Int(nullable: false, identity: true),
                        BuildingName = c.String(),
                        BuildingDesc = c.String(),
                    })
                .PrimaryKey(t => t.BuildingId);
            
            CreateTable(
                "dbo.ElectricityConsumed",
                c => new
                    {
                        ReadingTime = c.DateTime(nullable: false),
                        BuildingId = c.Int(nullable: false),
                        MssbValue = c.Int(nullable: false),
                        DbkL1Value = c.Int(nullable: false),
                        DbkL2Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReadingTime, t.BuildingId })
                .ForeignKey("dbo.Building", t => t.BuildingId, cascadeDelete: true)
                .Index(t => t.BuildingId);
            
            CreateTable(
                "dbo.ElectricityProduced",
                c => new
                    {
                        ReadingTime = c.DateTime(nullable: false),
                        BuildingId = c.Int(nullable: false),
                        ProducedValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReadingTime, t.BuildingId })
                .ForeignKey("dbo.Building", t => t.BuildingId, cascadeDelete: true)
                .Index(t => t.BuildingId);
            
            CreateTable(
                "dbo.Gas",
                c => new
                    {
                        ReadingTime = c.DateTime(nullable: false),
                        BuildingId = c.Int(nullable: false),
                        GasValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReadingTime, t.BuildingId })
                .ForeignKey("dbo.Building", t => t.BuildingId, cascadeDelete: true)
                .Index(t => t.BuildingId);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        BuildingId = c.Int(nullable: false),
                        RoomName = c.String(),
                        RoomDesc = c.String(),
                    })
                .PrimaryKey(t => t.RoomId)
                .ForeignKey("dbo.Building", t => t.BuildingId, cascadeDelete: true)
                .Index(t => t.BuildingId);
            
            CreateTable(
                "dbo.Temperature",
                c => new
                    {
                        ReadingTime = c.DateTime(nullable: false),
                        RoomId = c.Int(nullable: false),
                        BuildingId = c.Int(nullable: false),
                        TemperatureValue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReadingTime, t.RoomId })
                .ForeignKey("dbo.Room", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Water",
                c => new
                    {
                        ReadingTime = c.DateTime(nullable: false),
                        BuildingId = c.Int(nullable: false),
                        WaterHot = c.Int(nullable: false),
                        WaterCold = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ReadingTime, t.BuildingId })
                .ForeignKey("dbo.Building", t => t.BuildingId, cascadeDelete: true)
                .Index(t => t.BuildingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Water", "BuildingId", "dbo.Building");
            DropForeignKey("dbo.Temperature", "RoomId", "dbo.Room");
            DropForeignKey("dbo.Room", "BuildingId", "dbo.Building");
            DropForeignKey("dbo.Gas", "BuildingId", "dbo.Building");
            DropForeignKey("dbo.ElectricityProduced", "BuildingId", "dbo.Building");
            DropForeignKey("dbo.ElectricityConsumed", "BuildingId", "dbo.Building");
            DropIndex("dbo.Water", new[] { "BuildingId" });
            DropIndex("dbo.Temperature", new[] { "RoomId" });
            DropIndex("dbo.Room", new[] { "BuildingId" });
            DropIndex("dbo.Gas", new[] { "BuildingId" });
            DropIndex("dbo.ElectricityProduced", new[] { "BuildingId" });
            DropIndex("dbo.ElectricityConsumed", new[] { "BuildingId" });
            DropTable("dbo.Water");
            DropTable("dbo.Temperature");
            DropTable("dbo.Room");
            DropTable("dbo.Gas");
            DropTable("dbo.ElectricityProduced");
            DropTable("dbo.ElectricityConsumed");
            DropTable("dbo.Building");
        }
    }
}
