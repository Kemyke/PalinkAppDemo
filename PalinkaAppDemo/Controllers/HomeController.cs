using PalinkaAppDemo.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PalinkaAppDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dilution()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult ComputeDilution(DilutionViewModel vm)
        {
            var x = (vm.OriginalAmount * vm.OriginalConcentration) / vm.RequiredConcentration - vm.OriginalAmount;
            
            ModelState.SetModelValue("AdditionalAmount", new ValueProviderResult(x, "", CultureInfo.CurrentCulture));
            return View("Dilution");
        }
    }
}