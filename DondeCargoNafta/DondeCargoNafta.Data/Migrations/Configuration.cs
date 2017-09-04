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
                new Brand { BrandName = "AXION" },
                new Brand { BrandName = "ESSO" },
                new Brand { BrandName = "OIL" },
                new Brand { BrandName = "PETROBRAS" },
                new Brand { BrandName = "SHELL" },
                new Brand { BrandName = "YPF" },
                new Brand { BrandName = "OTHER" }
             );

            context.Fuels.AddOrUpdate(f => new { f.FuelName, f.FuelType, f.FuelGrade },
                new Fuel { FuelName = "SUPER", FuelType = FuelType.Gas, FuelGrade = FuelGrade.Regular },
                new Fuel { FuelName = "INFINIA", FuelType = FuelType.Gas, FuelGrade = FuelGrade.Premium },
                new Fuel { FuelName = "DIESEL", FuelType = FuelType.Diesel, FuelGrade = FuelGrade.Regular },
                new Fuel { FuelName = "DIESEL INFINIA", FuelType = FuelType.Diesel, FuelGrade = FuelGrade.Premium }
             );

            context.Addresses.AddOrUpdate(a => new {a.City, a.State, a.Street, a.Number }, 
                new Address { City = "ROS", State = "SFE", Street = "Avellaneda", Number = "700" });

            context.Locations.AddOrUpdate(l => new {l.Latitude, l.Longitude }, 
                new Location { Latitude = -32.939186, Longitude = -60.6783208 });

            context.Stations.AddOrUpdate(s => new { s.Address, s.Brand, s.Coordinates, s.IsGNC, s.StationName },
                new Station
                {
                    Address = context.Addresses.FirstOrDefault(),
                    Brand = context.Brands.SingleOrDefault(b => b.BrandName == "YPF"),
                    Coordinates = context.Locations.FirstOrDefault(),
                    IsGNC = true,
                    StationName = "YPF El Surtidor"
                });

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
