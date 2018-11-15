using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntertainmentAgency.Models
{
    public class TypeOfEntertainment
    {
        public TypeOfEntertainment()
        {
            ListOfCompetitions = new List<Competition>();
            ListOfDesigns = new List<Design>();
            ListOfPriceList = new List<PriceList>();
        }
        public int Id{get; set;}
        [Required]
        public string Type { get; set; }
        public string Img { get; set; }

        public virtual List<Design> ListOfDesigns { get; set; }
        public virtual List<Competition> ListOfCompetitions { get; set; }
        public virtual List<PriceList> ListOfPriceList { get; set; }
        
    }
}