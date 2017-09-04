using DondeCargoNafta.Data.Repositories;
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

            var viewModel = new RateViewModel() { Station = station };

            return View(viewModel);
        }

        //[HttpPost]
        //public ActionResult Rate()
        //{
        //    return View();
        //}

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
    }
}