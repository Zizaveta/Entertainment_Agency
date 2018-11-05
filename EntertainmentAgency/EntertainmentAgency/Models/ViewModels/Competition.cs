namespace EntertainmentAgency.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public virtual ApplicationUser user { get; set; }
        public double Price { get; set; }
        public virtual TypeOfEntertainment typeOfEntertainment { get; set; }
    }
}