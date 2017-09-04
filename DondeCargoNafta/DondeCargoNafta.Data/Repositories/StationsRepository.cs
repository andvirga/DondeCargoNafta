using DondeCargoNafta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeCargoNafta.Data.Repositories
{
    public class StationsRepository
    {
        private EFContext Context { get; set; } = new EFContext();

        public List<Station> GetStations()
        {
            return Context.Stations
                .Include(nameof(Station.Address))
                .Include(nameof(Station.Brand))
                .Include(nameof(Station.Coordinates))
                .Include(nameof(Station.FuelPrices))
                .ToList();
        }
    }
}