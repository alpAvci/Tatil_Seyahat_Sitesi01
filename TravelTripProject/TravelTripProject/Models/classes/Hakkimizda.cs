using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.classes
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string fotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}