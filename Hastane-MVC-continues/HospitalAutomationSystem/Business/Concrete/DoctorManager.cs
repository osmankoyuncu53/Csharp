using Business.Abstract;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DoctorManager : IDoctorService
    {
        IDoctorDal _doctorDal;

        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public void DoctorAdd(Doctor doctor)
        {
            _doctorDal.Insert(doctor);
        }

        public void DoctorDelete(Doctor doctor)
        {
            doctor.DoctorStatus = false;
            _doctorDal.Update(doctor);
        }

        public void DoctorUpdate(Doctor doctor)
        {
            _doctorDal.Update(doctor);
        }

        public Doctor GetByID(int id)
        {
            return _doctorDal.Get(x => x.DoctorID == id);
        }

        public List<Doctor> GetList()
        {
            return _doctorDal.List();
        }
    }
}
