using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntertainmentAgency.Models
{
    public class TypeOfEntertainment
    {
        public TypeOfEntertainment()
        {
            ListOfCompetitions = new List<Competition>();
            ListOfDesigns = new List<Design>();
        }
        public int Id{get; set;}
        [Required]
        public string Type { get; set; }
        public string Img { get; set; }

        public virtual IEnumerable<Design> ListOfDesigns { get; set; }
        public virtual IEnumerable<Competition> ListOfCompetitions { get; set; }
    }
}