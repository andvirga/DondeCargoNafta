using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeCargoNafta.Entities
{
    public class Price
    {
        [Key]
        public int PriceID { get; set; }

        public double PriceValue { get; set; }
    }
}
