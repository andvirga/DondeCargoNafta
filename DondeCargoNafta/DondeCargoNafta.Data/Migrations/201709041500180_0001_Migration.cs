namespace DondeCargoNafta.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0001_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        Number = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        BrandGroup = c.String(),
                    })
                .PrimaryKey(t => t.BrandID);
            
            CreateTable(
                "dbo.FuelPrices",
                c => new
                    {
                        FuelPriceID = c.Int(nullable: false, identity: true),
                        Fuel_FuelID = c.Int(),
                        Price_PriceID = c.Int(),
                        Station_StationID = c.Int(),
                    })
                .PrimaryKey(t => t.FuelPriceID)
                .ForeignKey("dbo.Fuels", t => t.Fuel_FuelID)
                .ForeignKey("dbo.Prices", t => t.Price_PriceID)
                .ForeignKey("dbo.Stations", t => t.Station_StationID)
                .Index(t => t.Fuel_FuelID)
                .Index(t => t.Price_PriceID)
                .Index(t => t.Station_StationID);
            
            CreateTable(
                "dbo.Fuels",
                c => new
                    {
                        FuelID = c.Int(nullable: false, identity: true),
                        FuelName = c.String(),
                        FuelType = c.Int(nullable: false),
                        FuelGrade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FuelID);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        PriceID = c.Int(nullable: false, identity: true),
                        PriceValue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PriceID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationID = c.Int(nullable: false, identity: true),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.LocationID);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        StationID = c.Int(nullable: false, identity: true),
                        StationName = c.String(),
                        IsGNC = c.Boolean(nullable: false),
                        Address_AddressID = c.Int(),
                        Brand_BrandID = c.Int(),
                        Coordinates_LocationID = c.Int(),
                    })
                .PrimaryKey(t => t.StationID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID)
                .ForeignKey("dbo.Brands", t => t.Brand_BrandID)
                .ForeignKey("dbo.Locations", t => t.Coordinates_LocationID)
                .Index(t => t.Address_AddressID)
                .Index(t => t.Brand_BrandID)
                .Index(t => t.Coordinates_LocationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FuelPrices", "Station_StationID", "dbo.Stations");
            DropForeignKey("dbo.Stations", "Coordinates_LocationID", "dbo.Locations");
            DropForeignKey("dbo.Stations", "Brand_BrandID", "dbo.Brands");
            DropForeignKey("dbo.Stations", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.FuelPrices", "Price_PriceID", "dbo.Prices");
            DropForeignKey("dbo.FuelPrices", "Fuel_FuelID", "dbo.Fuels");
            DropIndex("dbo.Stations", new[] { "Coordinates_LocationID" });
            DropIndex("dbo.Stations", new[] { "Brand_BrandID" });
            DropIndex("dbo.Stations", new[] { "Address_AddressID" });
            DropIndex("dbo.FuelPrices", new[] { "Station_StationID" });
            DropIndex("dbo.FuelPrices", new[] { "Price_PriceID" });
            DropIndex("dbo.FuelPrices", new[] { "Fuel_FuelID" });
            DropTable("dbo.Stations");
            DropTable("dbo.Locations");
            DropTable("dbo.Prices");
            DropTable("dbo.Fuels");
            DropTable("dbo.FuelPrices");
            DropTable("dbo.Brands");
            DropTable("dbo.Addresses");
        }
    }
}
