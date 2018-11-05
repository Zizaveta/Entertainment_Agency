using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntertainmentAgency.Models
{
    public class PriceList
    {
        public PriceList()
        {
            competitions = new List<Competition>();
            menu = new Dictionary<Menu, int>();
        }
        public int Id { get;set; }
        public virtual ApplicationUser user { get; set; }
        public virtual Design design { get; set; }
        public virtual IEnumerable<Competition> competitions { get; set; }
        public virtual IDictionary<Menu, int> menu { get; set; }
        public double Price { get; set; }
        public string ComentToOrder { get; set; }
    }
}