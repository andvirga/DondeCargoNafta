using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeCargoNafta.Entities
{
    public class Station
    {
        public Brand Brand { get; set; }

        public string Name { get; set; }

        public Location Coordinates { get; set; }

        public Address Address { get; set; }

        public Boolean IsGNC { get; set; }

        public List<FuelPrice> FuelPrices { get; set; }
    }
}
