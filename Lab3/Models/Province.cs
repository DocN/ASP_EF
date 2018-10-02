using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Province
    {
        [Key]
        public String ProvinceCode { get; set; }
        public String ProvinceName { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
