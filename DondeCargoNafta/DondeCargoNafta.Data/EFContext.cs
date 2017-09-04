using System;
using System.Data.Entity;
using DondeCargoNafta.Entities;

namespace DondeCargoNafta.Data
{
    public class EFContext : DbContext
    {
        public DbSet<Station> Stations { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Brand> Brands
        {
            get; set;
        }

        public DbSet<Fuel> Fuels
        {
            get; set;
        }

        public DbSet<FuelPrice> FuelPrices
        {
            get; set;
        }

        public DbSet<Location> Locations
        {
            get; set;
        }

        public DbSet<Price> Prices
        {
            get; set;
        }
    }
}
