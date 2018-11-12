using System.Collections.Generic;

namespace EntertainmentAgency.Models
{
    public enum StatusOfOrder { Edit, Send, InProcess, Finished};
    public class PriceList
    {
        public PriceList()
        {
            Competitions = new Dictionary<Competition, Employeer>();
            menu = new Dictionary<int, int>();
        }
        public int Id { get;set; }
        public virtual TypeOfEntertainment TypeOfEntertainment { get; set; }
        public virtual ApplicationUser user { get; set; }
        public virtual Design design { get; set; }
        public virtual IDictionary<Competition, Employeer> Competitions { get; set; }
        public virtual IDictionary<int, int> menu { get; set; }
        public double Price { get; set; }
        public string ComentToOrder { get; set; }
        public StatusOfOrder StatusOfOrder { get; set; }
    }
}