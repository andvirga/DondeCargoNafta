using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeCargoNafta.Entities
{
    public class FuelPrice
    {
        [Key]
        public int FuelPriceID { get; set; }

        public Fuel Fuel { get; set; }

        public Price Price { get; set; }
    }
}
