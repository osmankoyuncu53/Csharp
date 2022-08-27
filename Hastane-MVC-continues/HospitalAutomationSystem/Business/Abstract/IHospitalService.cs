using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHospitalService
    {
        List<Hospital> GetList();
        void HospitalAdd(Hospital hospital);
        Hospital GetByID(int id);
        void HospitalDelete(Hospital hospital);
        void HospitalUpdate(Hospital hospital);
    }
}
