using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeCargoNafta.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
