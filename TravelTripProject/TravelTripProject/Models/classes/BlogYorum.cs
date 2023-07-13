using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.classes
{
    public class BlogYorum
    {
        public IEnumerable<Blog> deger1 { get; set; }
        public IEnumerable<Blog> deger3 { get; set; }
        
        public IEnumerable<Yorum> deger2 { get; set; }
    }
}