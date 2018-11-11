using System.Collections.Generic;

namespace EntertainmentAgency.Models
{
    public class Competition
    {
        public Competition()
        {
            Employeers = new List<Employeer>();
            ListOfPriceList = new List<PriceList>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public virtual List<Employeer> Employeers { get; set; }
        public double Price { get; set; }
        public virtual TypeOfEntertainment typeOfEntertainment { get; set; }
        public virtual List<PriceList> ListOfPriceList { get; set; }
    }
}