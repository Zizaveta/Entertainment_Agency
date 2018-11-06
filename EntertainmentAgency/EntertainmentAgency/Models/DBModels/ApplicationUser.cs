using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace EntertainmentAgency.Models
{
    public enum MyRoles {User, Admin, Employeer}
    public class ApplicationUser : IdentityUser
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public virtual MyRoles MyRole { get; set; }
        public virtual List<PriceList> PriceLists { get; set; }
        public ApplicationUser()
        {
            PriceLists = new List<PriceList>();
        }
    }


}