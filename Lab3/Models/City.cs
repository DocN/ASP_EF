using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public String CityName { get; set; }
        public int Population { get; set; }

        public String ProvinceCode { get; set; }
        public Province Province { get; set; }
    }
}
