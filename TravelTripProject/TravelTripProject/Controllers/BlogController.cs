using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.classes;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        Context c = new Context();
        BlogYorum by = new BlogYorum();

        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();

            by.deger1 = c.Blogs.ToList();
            by.deger3 = c.Blogs.OrderByDescending(b => b.ID).Take(4).ToList();
            return View(by);
        }



        public ActionResult BlogDetay(int? id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();

            by.deger1 = c.Blogs.Where(x => x.ID == id).OrderByDescending(b => b.ID).Take(4).ToList();
            by.deger2 = c.Yorums.Where(x => x.Blogid == id).ToList();

            return View(by);
        }







        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorum y)
        {
            c.Yorums.Add(y);
            c.SaveChanges();
            return PartialView();

        }


    }
}