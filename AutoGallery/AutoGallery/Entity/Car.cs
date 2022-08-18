using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGallery.Entity
{
    class Car
    {
        [Key]
        public int car_id { get; set; }
        public string car_plakaNumber { get; set; }
        public string car_brand { get; set; }
        public string car_model { get; set; }
        public string car_year { get; set; }
        public string car_fuel { get; set; }
        public string car_gear { get; set; }
        public string car_km { get; set; }
        public string car_driverLicense { get; set; }
        public string car_traction { get; set; }
        public string car_door { get; set; }
        public string car_color { get; set; }
        public string car_damage { get; set; }
        public string car_money { get; set; }
        public string car_image { get; set; }
        public string car_info { get; set; }

        public virtual ICollection<RentACar> RentACars { get; set; }


    }
}
