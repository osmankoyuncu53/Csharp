using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        [StringLength(50)]
        public string PatientName { get; set; }
        [StringLength(50)]
        public string PatientSurname { get; set; }
        [StringLength(11)]
        public string PatientIdentityNumber { get; set; }
        [StringLength(50)]
        public string PatientPassword { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
