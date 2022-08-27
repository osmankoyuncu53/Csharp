using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPoliclinicService
    {
        List<Policlinic> GetList();
        void PoliclinicAdd(Policlinic policlinic);
        Policlinic GetByID(int id);
        void PoliclinicDelete(Policlinic policlinic);
        void PoliclinicUpdate(Policlinic policlinic);
    }
}
