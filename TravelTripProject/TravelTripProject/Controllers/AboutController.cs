using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.classes;

namespace TravelTripProject.Controllers
{
  
    public class AboutController : Controller
    {
        // GET: About
       
        Context C = new Context();
        public ActionResult Index()
        {
            var degerler = C.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}