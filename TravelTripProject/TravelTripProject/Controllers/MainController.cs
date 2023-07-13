using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models;
using TravelTripProject.Models.classes;

namespace TravelTripProject.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(4).ToList();
            return View(degerler);
        }



        public PartialViewResult Partial1()
        {
            var deger1 = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(deger1);
        }




        public PartialViewResult partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);

        }




        public PartialViewResult partial3()
        {
            var deger3 = c.Blogs.OrderByDescending(b=>b.ID).Take(5).ToList();
            return PartialView(deger3);

        }




        public PartialViewResult partial4()
        {
            var deger4 = c.Blogs.Take(2).ToList();
            return PartialView(deger4);
        }




        public PartialViewResult partial5()
        {
            var deger5 = c.Blogs.OrderByDescending(b => b.ID).Take(2).ToList();
            return PartialView(deger5);

        }






    }





}
