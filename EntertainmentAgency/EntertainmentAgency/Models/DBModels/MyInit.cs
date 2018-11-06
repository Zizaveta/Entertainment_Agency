using System.Data.Entity;

namespace EntertainmentAgency.Models
{
    internal class MyInit<T> : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
           
            base.Seed(context);
        }
    }
}