using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        [StringLength(20)]
        public string CityName { get; set; }
        public int DistrictID { get; set; }
        public virtual District District { get; set; }
        public ICollection<Hospital> Hospitals { get; set; }
    }
}
