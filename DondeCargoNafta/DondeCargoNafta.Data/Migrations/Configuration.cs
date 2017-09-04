namespace DondeCargoNafta.Data.Migrations
{
    using DondeCargoNafta.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DondeCargoNafta.Data.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DondeCargoNafta.Data.EFContext context)
        {
            context.Brands.AddOrUpdate(b => new { b.BrandName }, 
                new Brand { BrandID = 1, BrandName = "AXION" },
                new Brand { BrandID = 2, BrandName = "ESSO" },
                new Brand { BrandID = 3, BrandName = "OIL" },
                new Brand { BrandID = 4, BrandName = "PETROBRAS" },
                new Brand { BrandID = 5, BrandName = "SHELL" },
                new Brand { BrandID = 6, BrandName = "YPF" },
                new Brand { BrandID = 7, BrandName = "OTHER" }
             );

            context.SaveChanges();

            context.Fuels.AddOrUpdate(f => new { f.FuelName, f.FuelType, f.FuelGrade },
                new Fuel { FuelName = "SUPER", FuelType = FuelType.Gas, FuelGrade = FuelGrade.Regular },
                new Fuel { FuelName = "INFINIA", FuelType = FuelType.Gas, FuelGrade = FuelGrade.Premium },
                new Fuel { FuelName = "DIESEL", FuelType = FuelType.Diesel, FuelGrade = FuelGrade.Regular },
                new Fuel { FuelName = "DIESEL INFINIA", FuelType = FuelType.Diesel, FuelGrade = FuelGrade.Premium }
             );

            context.SaveChanges();

            context.Addresses.AddOrUpdate(a => new { a.City, a.State, a.Street, a.Number }, 
                new Address { AddressID = 1, City = "ROS", State = "SFE", Street = "Avellaneda y Cordoba", Number = "" },
                new Address { AddressID = 2, City = "ROS", State = "SFE", Street = "Oroño y 3 de Febrero", Number = "" },
                new Address { AddressID = 3, City = "ROS", State = "SFE", Street = "Cordoba y Oroño", Number = "" },
                new Address { AddressID = 4, City = "ROS", State = "SFE", Street = "Oroño y 9 de Julio", Number = "" },
                new Address { AddressID = 5, City = "ROS", State = "SFE", Street = "Zeballos y Mitre", Number = "" },
                new Address { AddressID = 6, City = "ROS", State = "SFE", Street = "27 Febrero y Maipu", Number = "" });

            context.SaveChanges();


            context.Locations.AddOrUpdate(l => new { l.Latitude, l.Longitude },
                new Location { LocationID = 1, Latitude = -32.939186, Longitude = -60.6783208 },
                new Location { LocationID = 2, Latitude = -32.950115, Longitude = -60.655131 },
                new Location { LocationID = 3, Latitude = -32.943738, Longitude = -60.653540 },
                new Location { LocationID = 4, Latitude = -32.951205, Longitude = -60.654990 },
                new Location { LocationID = 5, Latitude = -32.954650, Longitude = -60.641566 },
                new Location { LocationID = 6, Latitude = -32.968367, Longitude = -60.641108 });

            context.SaveChanges();

            //context.Stations.AddOrUpdate(s => new { s.Address, s.Brand, s.Coordinates, s.IsGNC, s.StationName },
            //    new Station
            //    {
            //        Address = context.Addresses.FirstOrDefault(x => x.AddressID == 1),
            //        Brand = context.Brands.SingleOrDefault(b => b.BrandName == "YPF"),
            //        Coordinates = context.Locations.FirstOrDefault(l => l.LocationID == 1),
            //        IsGNC = true,
            //        StationName = "El Surtidor"
            //    },
            //    new Station
            //    {
            //        Address = context.Addresses.FirstOrDefault(x => x.AddressID == 2),
            //        Brand = context.Brands.SingleOrDefault(b => b.BrandName == "YPF"),
            //        Coordinates = context.Locations.FirstOrDefault(x => x.LocationID == 2),
            //        IsGNC = true,
            //        StationName = "ACA Oroño"
            //    },
            //    new Station
            //    {
            //        Address = context.Addresses.FirstOrDefault(x => x.AddressID == 3),
            //        Brand = context.Brands.SingleOrDefault(b => b.BrandName == "SHELL"),
            //        Coordinates = context.Locations.FirstOrDefault(x => x.LocationID == 3),
            //        IsGNC = true,
            //        StationName = "Shell Oroño"
            //    },
            //    new Station
            //    {
            //        Address = context.Addresses.FirstOrDefault(x => x.AddressID == 4),
            //        Brand = context.Brands.SingleOrDefault(b => b.BrandName == "ESSO"),
            //        Coordinates = context.Locations.FirstOrDefault(x => x.LocationID == 4),
            //        IsGNC = true,
            //        StationName = "ESSO Oroño"
            //    },
            //    new Station
            //    {
            //        Address = context.Addresses.FirstOrDefault(x => x.AddressID == 5),
            //        Brand = context.Brands.SingleOrDefault(b => b.BrandName == "OTHER"),
            //        Coordinates = context.Locations.FirstOrDefault(x => x.LocationID == 5),
            //        IsGNC = true,
            //        StationName = "GNC Mitre y Zeballos"
            //    },
            //    new Station
            //    {
            //        Address = context.Addresses.FirstOrDefault(x => x.AddressID == 6),
            //        Brand = context.Brands.SingleOrDefault(b => b.BrandName == "OIL"),
            //        Coordinates = context.Locations.FirstOrDefault(x => x.LocationID == 6),
            //        IsGNC = true,
            //        StationName = "OIL Diagonal Maipu"
            //    });

            //context.SaveChanges();

            //context.People.AddOrUpdate(p => new { p.FirstName, p.LastName }, people);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
