using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DondeCargoNafta.Entities
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }

        public string BrandName { get; set; }

        public string BrandGroup { get; set; }
    }
}
