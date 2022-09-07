using Business.Concrete;
using DataAccess.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalAutomationSystem.Controllers.UserPanel
{
    public class UserHomeController : Controller
    {
        // GET: UserHome
        AppointmentManager am = new AppointmentManager(new EfAppointmentDal());
        PatientManager pm = new PatientManager(new EfPatientDal());
        DoctorManager dm = new DoctorManager(new EfDoctorDal());
        [HttpGet]
        public ActionResult Index()
        {
            List<SelectListItem> valuePatient = (from x in pm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.PatientIdentityNumber,
                                                        Value = x.PatientID.ToString()
                                                    }).ToList();

            List<SelectListItem> valueDoctor = (from x in dm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.DoctorName,
                                                     Value = x.DoctorID.ToString()
                                                 }).ToList();
            ViewBag.vlp = valuePatient;
            ViewBag.vld = valueDoctor;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Appointment p)
        {
            am.AppointmentAdd(p);
            return RedirectToAction("Index");
        }


    }
}