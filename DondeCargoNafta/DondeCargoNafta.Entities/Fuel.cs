using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeCargoNafta.Entities
{
    public class Fuel
    {
        public string FuelName { get; set; }

        public FuelType FuelType { get; set; }

        public FuelGrade FuelGrade { get; set; }
    }
}
