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
    public class HospitalManager:IHospitalService
    {
        IHospitalDal _hospitalDal;

        public HospitalManager(IHospitalDal hospitalDal)
        {
            _hospitalDal = hospitalDal;
        }

        public Hospital GetByID(int id)
        {
            return _hospitalDal.Get(x => x.HospitalID == id);
        }

        public List<Hospital> GetList()
        {
            return _hospitalDal.List();
        }

        public void HospitalAdd(Hospital hospital)
        {
            _hospitalDal.Insert(hospital);
        }

        public void HospitalDelete(Hospital hospital)
        {
            _hospitalDal.Delete(hospital);
        }

        public void HospitalUpdate(Hospital hospital)
        {
            _hospitalDal.Update(hospital);
        }
    }
}
