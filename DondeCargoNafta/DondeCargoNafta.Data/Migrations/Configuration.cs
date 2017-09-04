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
                new Fuel { FuelName = "REGULAR GAS", FuelType = FuelType.Gas, FuelGrade = FuelGrade.Regular },
                new Fuel { FuelName = "PREMIUM GAS", FuelType = FuelType.Gas, FuelGrade = FuelGrade.Premium },
                new Fuel { FuelName = "REGULAR DIESEL", FuelType = FuelType.Diesel, FuelGrade = FuelGrade.Regular },
                new Fuel { FuelName = "PREMIUM DIESEL", FuelType = FuelType.Diesel, FuelGrade = FuelGrade.Premium }
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
        }
    }
}
