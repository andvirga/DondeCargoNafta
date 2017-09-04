using DondeCargoNafta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DondeCargoNafta.Models
{
    public class RateViewModel
    {
        public Station Station { get; set; }

        public double RegularGas { get; set; }

        public double PremiumGas { get; set; }

        public double RegularDiesel { get; set; }

        public double PremiumDiesel { get; set; }
    }
}