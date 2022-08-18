using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGallery.Entity
{
    class Customer
    {
        [Key]
        public int customer_id { get; set; }
        public string customer_tcNo { get; set; }
        public string customer_name { get; set; }
        public string customer_surname { get; set; }
        public string customer_dateOfBirth { get; set; }
        public string customer_job { get; set; }
        public string customer_phoneNumber { get; set; }
        public string customer_email { get; set; }
        public string customer_adress { get; set; }
        public string customer_driverLicense { get; set; }
        public string customer_licenseType { get; set; }
        public string customer_note { get; set; }
        public string customer_image { get; set; }
        public virtual ICollection<RentACar> RentACars { get; set; }





    }
}
