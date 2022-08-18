using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class District
    {
        [Key]
        public int DistrictID { get; set; }
        [StringLength(20)]
        public string DistrictName { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<Hospital> Hospitals { get; set; }
    }
}
