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

namespace HospitalAutomationSystem.Controllers
{
    public class AdminDoctorController : Controller
    {
        // GET: AdminDoctor
        DoctorManager dm = new DoctorManager(new EfDoctorDal());
        HospitalManager hm = new HospitalManager(new EfHospitalDal());
        PoliclinicManager pm = new PoliclinicManager(new EfPoliclinicDal());

        [Authorize]
        public ActionResult Index()
        {
            var doctorValues = dm.GetList();
            return View(doctorValues);
        }

        [HttpGet]
        public ActionResult AddDoctor()
        {
            List<SelectListItem> valueHospital = (from x in hm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.HospitalName,
                                                      Value = x.HospitalID.ToString()
                                                  }).ToList();

            List<SelectListItem> valuePoliclinic = (from x in pm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.PoliclinicName,
                                                    Value = x.PoliclinicID.ToString()
                                                }).ToList();
            ViewBag.vlh = valueHospital;
            ViewBag.vlp = valuePoliclinic;
            return View();
        }
        [HttpPost]
        public ActionResult AddDoctor(Doctor p)
        {
            DoctorValidator doctorValidator = new DoctorValidator();
            ValidationResult results = doctorValidator.Validate(p);

            if (!results.IsValid)
            {
                List<SelectListItem> valueHospital = (from x in hm.GetList()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.HospitalName,
                                                          Value = x.HospitalID.ToString()
                                                      }).ToList();

                List<SelectListItem> valuePoliclinic = (from x in pm.GetList()
                                                        select new SelectListItem
                                                        {
                                                            Text = x.PoliclinicName,
                                                            Value = x.PoliclinicID.ToString()
                                                        }).ToList();
                ViewBag.vlh = valueHospital;
                ViewBag.vlp = valuePoliclinic;
            }

            if (results.IsValid)
            {
                dm.DoctorAdd(p);
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

        [HttpGet]
        public ActionResult UpdateDoctor(int id)
        {
            List<SelectListItem> valueHospital = (from x in hm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.HospitalName,
                                                      Value = x.HospitalID.ToString()
                                                  }).ToList();

            List<SelectListItem> valuePoliclinic = (from x in pm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.PoliclinicName,
                                                        Value = x.PoliclinicID.ToString()
                                                    }).ToList();
            ViewBag.vlh = valueHospital;
            ViewBag.vlp = valuePoliclinic;

            var doctorValue = dm.GetByID(id);
            return View(doctorValue);
        }
        [HttpPost]
        public ActionResult UpdateDoctor(Doctor p)
        {
           dm.DoctorUpdate(p);
           return RedirectToAction("Index");
        }
        public ActionResult DeleteDoctor(int id)
        {
            var categoryvalue = dm.GetByID(id);
            dm.DoctorDelete(categoryvalue);
            return RedirectToAction("Index");
        }
    }
}