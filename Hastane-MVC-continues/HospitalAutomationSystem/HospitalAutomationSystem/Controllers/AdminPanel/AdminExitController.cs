using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HospitalAutomationSystem.Controllers.AdminPanel
{
    public class AdminExitController : Controller
    {
        // GET: AdminExit
        [Authorize]
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("../AdminLogin/Index/");
        }
    }
}