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
    public class PatientManager:IPatientService
    {
        IPatientDal _patientDal;

        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        public Patient GetByID(int id)
        {
            return _patientDal.Get(x => x.PatientID == id);
        }

        public List<Patient> GetList()
        {
            return _patientDal.List();
        }

        public void PatientAdd(Patient patient)
        {
            _patientDal.Insert(patient);
        }

        public void PatientDelete(Patient patient)
        {
            patient.PatientStatus = false;
            _patientDal.Update(patient);
        }

        public void PatientUpdate(Patient patient)
        {
            _patientDal.Update(patient);
        }
    }
}
