using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public JsonResult getPatientlist()
        {
            patientRepository repo = new patientRepository();
            return Json(repo.GetAllPatients(), JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetPatientById( int patid)
        {
            patientRepository repo = new patientRepository();
            return Json(repo.GetPatient(patid), JsonRequestBehavior.AllowGet);

        }

    }
}
