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
    public class AdminPoliclinicController : Controller
    {
        // GET: AdminPoliclinic
        PoliclinicManager pm = new PoliclinicManager(new EfPoliclinicDal());
        [Authorize]
        public ActionResult Index()
        {
            var policlinicValue = pm.GetList();
            return View(policlinicValue);
        }
        [HttpGet]
        public ActionResult AddPoliclinic()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPoliclinic(Policlinic p)
        {
            PoliclinicValidator policlinicValidator = new PoliclinicValidator();
            ValidationResult results = policlinicValidator.Validate(p);

            if (results.IsValid)
            {
                pm.PoliclinicAdd(p);
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
        public ActionResult UpdatePoliclinic(int id)
        {
            var policlinicValue = pm.GetByID(id);
            return View(policlinicValue);
        }
        [HttpPost]
        public ActionResult UpdatePoliclinic(Policlinic p)
        {
            pm.PoliclinicUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeletePoliclinic(int id)
        {
            var policlinicValue = pm.GetByID(id);
            pm.PoliclinicDelete(policlinicValue);
            return RedirectToAction("Index");
        }
    }
}