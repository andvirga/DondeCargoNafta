using DondeCargoNafta.Data.Repositories;
using DondeCargoNafta.Entities;
using DondeCargoNafta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DondeCargoNafta.Controllers
{
    public class HomeController : Controller
    {
        private readonly StationsRepository _stationRepo = new StationsRepository();

        public ActionResult Index()
        {
            var stations = this._stationRepo.GetStations();
            return View(stations);
        }

        [Route("Home/Rate/{ID:int}")]
        public ActionResult Rate(int ID)
        {
            var station = this._stationRepo.GetStationByID(ID);

            var viewModel = new RateViewModel()
            {
                Station = station,
                RegularGas = station.FuelPrices.SingleOrDefault(p => p.Fuel.FuelType == FuelType.Gas && p.Fuel.FuelGrade == FuelGrade.Regular)?.Price.PriceValue ?? 0,
                PremiumGas = station.FuelPrices.SingleOrDefault(p => p.Fuel.FuelType == FuelType.Gas && p.Fuel.FuelGrade == FuelGrade.Premium)?.Price.PriceValue ?? 0,
                RegularDiesel = station.FuelPrices.SingleOrDefault(p => p.Fuel.FuelType == FuelType.Diesel && p.Fuel.FuelGrade == FuelGrade.Regular)?.Price.PriceValue ?? 0,
                PremiumDiesel = station.FuelPrices.SingleOrDefault(p => p.Fuel.FuelType == FuelType.Diesel && p.Fuel.FuelGrade == FuelGrade.Premium)?.Price.PriceValue ?? 0
            };

            return View(viewModel);
        }

        [Route("Home/Rate")]
        [HttpPost]
        public ActionResult Rate(RateViewModel rateViewModel)
        {
            var stationToUpdate = this._stationRepo.GetStationByID(rateViewModel.Station.StationID);

            var fuelPrices = new List<FuelPrice>();

            //RegularGas
            UpdateStationPrice(stationToUpdate, rateViewModel.RegularGas, FuelType.Gas, FuelGrade.Regular);

            //PremiumGas
            UpdateStationPrice(stationToUpdate, rateViewModel.PremiumGas, FuelType.Gas, FuelGrade.Premium);

            //RegularDiesel
            UpdateStationPrice(stationToUpdate, rateViewModel.RegularDiesel, FuelType.Diesel, FuelGrade.Regular);

            //PremiumDiesel
            UpdateStationPrice(stationToUpdate, rateViewModel.PremiumDiesel, FuelType.Diesel, FuelGrade.Premium);

            this._stationRepo.UpdateStation(stationToUpdate);

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private void UpdateStationPrice(Station station, double priceValue, FuelType fuelType, FuelGrade fuelGrade)
        {
            var fuelPrice = station.FuelPrices.SingleOrDefault(x => x.Fuel?.FuelType == fuelType && x.Fuel?.FuelGrade == fuelGrade);
            if (fuelPrice == null)
            {
                fuelPrice = new FuelPrice()
                {
                    Fuel = _stationRepo.GetFuelByTypeAndGrade(fuelType, fuelGrade),
                    Price = new Price()
                };

                station.FuelPrices.Add(fuelPrice);
            }

            fuelPrice.Price.PriceValue = priceValue;
        }
    }
}