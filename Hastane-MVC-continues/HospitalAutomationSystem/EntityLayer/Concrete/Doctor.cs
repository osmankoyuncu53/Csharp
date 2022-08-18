using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        [StringLength(50)]
        public string DoctorName { get; set; }
        [StringLength(50)]
        public string DoctorSurname { get; set; }
        public bool DoctorStatus { get; set; }

        public int HospitalID { get; set; }
        public virtual Hospital Hospital { get; set; }
        public int PoliclinicID { get; set; }
        public virtual Policlinic Policlinic { get; set; }
            
        public ICollection<Appointment> Appointments { get; set; }

    }
}
