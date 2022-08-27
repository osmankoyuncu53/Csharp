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
    public class PoliclinicManager:IPoliclinicService
    {
        IPoliclinicDal _policlinicDal;

        public PoliclinicManager(IPoliclinicDal policlinicDal)
        {
            _policlinicDal = policlinicDal;
        }

        public Policlinic GetByID(int id)
        {
            return _policlinicDal.Get(x => x.PoliclinicID == id);
        }

        public List<Policlinic> GetList()
        {
            return _policlinicDal.List();
        }

        public void PoliclinicAdd(Policlinic policlinic)
        {
            _policlinicDal.Insert(policlinic);
        }

        public void PoliclinicDelete(Policlinic policlinic)
        {
            _policlinicDal.Delete(policlinic);
        }

        public void PoliclinicUpdate(Policlinic policlinic)
        {
            _policlinicDal.Update(policlinic);
        }
    }
}
