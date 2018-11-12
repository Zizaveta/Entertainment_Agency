using System.Collections.Generic;

namespace EntertainmentAgency.Models
{
    public class Design
    {
        public Design()
        {
            ListOfPriceLists = new List<PriceList>();
        }
        public int Id { get; set; }
        public string Img { get; set; }
        public double Price { get; set; }
        public virtual TypeOfEntertainment typeOfEntertainment { get; set; }
        public virtual List<PriceList> ListOfPriceLists { get; set; }
    }
}