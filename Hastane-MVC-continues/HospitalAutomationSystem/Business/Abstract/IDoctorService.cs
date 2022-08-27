using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDoctorService
    {
        List<Doctor> GetList();
        void DoctorAdd(Doctor doctor);
        Doctor GetByID(int id);
        void DoctorDelete(Doctor doctor);
        void DoctorUpdate(Doctor doctor);
    }
}
