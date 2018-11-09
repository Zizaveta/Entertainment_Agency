using System.Collections.Generic;

namespace EntertainmentAgency.Models
{
    public class Competition
    {
        public Competition()
        {
            user = new List<ApplicationUser>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public virtual List<ApplicationUser> user { get; set; }
        public double Price { get; set; }
        public virtual TypeOfEntertainment typeOfEntertainment { get; set; }
    }
}