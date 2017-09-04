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
                .Include($"{nameof(Station.FuelPrices)}.{nameof(FuelPrice.Fuel)}")
                .Include($"{nameof(Station.FuelPrices)}.{nameof(FuelPrice.Price)}")
                .ToList();
        }

        public Station GetStationByID(int ID)
        {
            return Context.Stations
                .Include(nameof(Station.Address))
                .Include(nameof(Station.Brand))
                .Include(nameof(Station.Coordinates))
                .Include(nameof(Station.FuelPrices))
                .Include($"{nameof(Station.FuelPrices)}.{nameof(FuelPrice.Fuel)}")
                .Include($"{nameof(Station.FuelPrices)}.{nameof(FuelPrice.Price)}")
                .SingleOrDefault(s => s.StationID == ID);
        }

        public void UpdateStation(Station stationToUpdate)
        {
            try
            {
                Context.Stations.Attach(stationToUpdate);

                Context.SaveChanges();
            }
            catch
            {
                throw new Exception("Error al guardar en Base de Datos");
            }
        }

        public Fuel GetFuelByTypeAndGrade(FuelType fuelType, FuelGrade fuelGrade)
        {
            var fuel = Context.Fuels.SingleOrDefault(f => f.FuelType == fuelType && f.FuelGrade == fuelGrade);

            if (fuel == null)
                fuel = new Fuel() { FuelType = fuelType, FuelGrade = fuelGrade, FuelName = fuelType.ToString() + fuelGrade.ToString() };

            return fuel;
        }
    }
}