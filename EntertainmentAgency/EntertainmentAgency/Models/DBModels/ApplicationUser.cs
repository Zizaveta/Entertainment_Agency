using Microsoft.AspNet.Identity.EntityFramework;

namespace EntertainmentAgency.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public ApplicationUser()
        {
        }
    }
}