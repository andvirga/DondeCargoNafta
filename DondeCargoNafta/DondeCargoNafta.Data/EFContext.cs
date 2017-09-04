using System;
using System.Data.Entity;
using DondeCargoNafta.Entities;

namespace DondeCargoNafta.Data
{
    public class EFContext: DbContext
    {
        public DbSet<Station> Stations { get; set; }
    }
}
