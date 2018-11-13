using System.Collections.Generic;

namespace EntertainmentAgency.Models
{
    public enum StatusOfOrder { Edit, Send, InProcess, Finished};
    public class PriceList
    {
        public PriceList()
        {
            Competitions = new List<Competition>();
            menu = new List<MenuCount>();
        }
        public int Id { get;set; }
        public virtual TypeOfEntertainment TypeOfEntertainment { get; set; }
        public virtual ApplicationUser user { get; set; }
        public virtual Design design { get; set; }
        public virtual List<Competition> Competitions { get; set; }
        public virtual List<MenuCount> menu { get; set; }
        public double Price { get; set; }
        public string ComentToOrder { get; set; }
        public StatusOfOrder StatusOfOrder { get; set; }
    }
}