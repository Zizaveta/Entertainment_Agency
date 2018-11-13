using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntertainmentAgency.Models
{
    public class MenuCount
    {
        public MenuCount()
        {
            PriceLists = new List<PriceList>();
        }
        public int Id { get; set; }
        public virtual Menu Menu{get;set;}
        public int Q_ty { get; set; }
        public virtual List<PriceList> PriceLists { get; set; }
    }
}