using DataAccess.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalAutomationSystem.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: AdminHome
        [Authorize]
        public ActionResult Index()
        {
            Context conn = new Context();

            var resultsDoctor = conn.Doctors.Count();
            ViewBag.DoctorCount = resultsDoctor;

            var resultsHospital = conn.Hospitals.Count();
            ViewBag.HospitalCount = resultsHospital;

            var resultsPatient = conn.Patients.Count();
            ViewBag.PatientCount = resultsPatient;

            var resultsAppointment = conn.Appointments.Where(p=>p.AppointmentStatus==true).Count();
            ViewBag.AppointmentCount = resultsAppointment;
            return View();
        }
    }
}