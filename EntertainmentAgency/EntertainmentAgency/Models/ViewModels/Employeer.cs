using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntertainmentAgency.Models
{
    public class Employeer
    {
        public Employeer()
        {
            Competitions = new List<Competition>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public virtual List<Competition> Competitions { get; set; }
    }
}