using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeCargoNafta.Entities
{
    public class FuelPrice
    {
        public Fuel Fuel { get; set; }

        public Price Price { get; set; }
    }
}
