using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntertainmentAgency.Models
{
    public class Design
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public double Price { get; set; }
        public virtual TypeOfEntertainment typeOfEntertainment { get; set; }
    }
}