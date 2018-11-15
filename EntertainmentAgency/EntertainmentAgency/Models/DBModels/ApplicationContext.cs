using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntertainmentAgency.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("DefaultConnection") {
            Database.SetInitializer<ApplicationContext>(new MyInit<ApplicationContext>());
        }
        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<Design> Designes { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Employeer> Employeers { get; set; }
        public virtual DbSet<PriceList> PriceLists { get; set; }
        public virtual DbSet<TypeOfEntertainment> TypeOfEntertainments { get; set; }
        public virtual DbSet<Idx> Idxes { get; set; }
        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}