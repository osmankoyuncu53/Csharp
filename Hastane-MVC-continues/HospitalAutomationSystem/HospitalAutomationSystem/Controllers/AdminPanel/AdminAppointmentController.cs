using Business.Concrete;
using Business.ValidationRules;
using DataAccess.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalAutomationSystem.Controllers.AdminPanel
{
    public class AdminAppointmentController : Controller
    {
        // GET: AdminAppointment
        AppointmentManager am = new AppointmentManager(new EfAppointmentDal());
        PatientManager pm = new PatientManager(new EfPatientDal());
        DoctorManager dm = new DoctorManager(new EfDoctorDal());
        [Authorize]
        public ActionResult Index()
        {
            var appointmentValue = am.GetList();
            return View(appointmentValue);
        }

        [HttpGet]
        public ActionResult AddAppointment()
        {
            List<SelectListItem> valuePatient = (from x in pm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.PatientName,
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
        public ActionResult AddAppointment(Appointment p)
        {
            AppointmentValidator doctorValidator = new AppointmentValidator();
            ValidationResult results = doctorValidator.Validate(p);

            if (!results.IsValid)
            {
                List<SelectListItem> valuePatient = (from x in pm.GetList()
                                                     select new SelectListItem
                                                     {
                                                         Text = x.PatientName,
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
            }

            if (results.IsValid)
            {
                am.AppointmentAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteAppointment(int id)
        {
            var appointmentValue = am.GetByID(id);
            am.AppointmentDelete(appointmentValue);
            return RedirectToAction("Index");
        }
    }
}