using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeCargoNafta.Entities
{
    public class Station
    {
        [Key]
        public int StationID { get; set; }

        public Brand Brand { get; set; }

        public string StationName { get; set; }

        public Location Coordinates { get; set; }

        public Address Address { get; set; }

        public Boolean IsGNC { get; set; }

        public List<FuelPrice> FuelPrices { get; set; }
    }
}
