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
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public void AppointmentAdd(Appointment appointment)
        {
            _appointmentDal.Insert(appointment);
        }

        public void AppointmentDelete(Appointment appointment)
        {
            appointment.AppointmentStatus = false;
            _appointmentDal.Update(appointment);
        }

        public void AppointmentUpdate(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
        }

        public Appointment GetByID(int id)
        {
            return _appointmentDal.Get(x => x.AppointmentID == id);
        }

        public List<Appointment> GetList()
        {
            return _appointmentDal.List();
        }
    }
}
