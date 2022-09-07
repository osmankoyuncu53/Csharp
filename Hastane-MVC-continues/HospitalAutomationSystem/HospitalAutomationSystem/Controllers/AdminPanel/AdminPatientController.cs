using Business.Concrete;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalAutomationSystem.Controllers.AdminPanel
{
    public class AdminPatientController : Controller
    {
        // GET: AdminPatient
        
        PatientManager pm = new PatientManager(new EfPatientDal());
        [Authorize]
        public ActionResult Index()
        {
            var patientValues = pm.GetList();
            return View(patientValues);
        }
        public ActionResult DeletePatient(int id)
        {
            var hospitalValue = pm.GetByID(id);
            pm.PatientDelete(hospitalValue);
            return RedirectToAction("Index");
        }
    }
}