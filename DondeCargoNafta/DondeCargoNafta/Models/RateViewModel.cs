using DondeCargoNafta.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DondeCargoNafta.Models
{
    public class RateViewModel
    {
        public Station Station { get; set; }

        [DisplayName("Nafta Super")]
        public double RegularGas { get; set; }

        [DisplayName("Nafta Premium")]
        public double PremiumGas { get; set; }

        [DisplayName("Diesel Común")]
        public double RegularDiesel { get; set; }

        [DisplayName("Diesel Premium")]
        public double PremiumDiesel { get; set; }
    }
}