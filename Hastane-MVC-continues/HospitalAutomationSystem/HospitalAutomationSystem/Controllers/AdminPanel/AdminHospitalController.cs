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
    public class AdminHospitalController : Controller
    {
        // GET: AdminHospital
        HospitalManager hm = new HospitalManager(new EfHospitalDal());
        DistrictManager dm = new DistrictManager(new EfDistrictDal());
        [Authorize]
        public ActionResult Index()
        {
            var hospitalValues = hm.GetList();
            return View(hospitalValues);
        }

        [HttpGet]
        public ActionResult AddHospital()
        {
            List<SelectListItem> valueDistrict = (from x in dm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.DistrictName,
                                                      Value = x.DistrictID.ToString()
                                                  }).ToList();
            ViewBag.vld = valueDistrict;
            return View();
        }
        [HttpPost]
        public ActionResult AddHospital(Hospital p)
        {
            HospitalValidator hospitalValidator = new HospitalValidator();
            ValidationResult results = hospitalValidator.Validate(p);

            if (!results.IsValid)
            {
                List<SelectListItem> valueDistrict = (from x in dm.GetList()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.DistrictName,
                                                          Value = x.DistrictID.ToString()
                                                      }).ToList();
                ViewBag.vld = valueDistrict;
            }

            if (results.IsValid)
            {
                hm.HospitalAdd(p);
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
        public ActionResult UpdateHospital(int id)
        {
            List<SelectListItem> valueDistrict = (from x in dm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.DistrictName,
                                                      Value = x.DistrictID.ToString()
                                                  }).ToList();
            ViewBag.vld = valueDistrict;

            var hospitalValue = hm.GetByID(id);
            return View(hospitalValue);
        }
        [HttpPost]
        public ActionResult UpdateHospital(Hospital p)
        {
            hm.HospitalUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteHospital(int id)
        {
            var hospitalValue = hm.GetByID(id);
            hm.HospitalDelete(hospitalValue);
            return RedirectToAction("Index");
        }
    }
}