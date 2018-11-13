using EntertainmentAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntertainmentAgency.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public PartialViewResult _PartialMenuView()
        {
            List<EntertainmentAgency.Models.Menu> m;
            using (ApplicationContext db = new ApplicationContext())
            {
                m = db.Menu.OrderBy(elem => elem.Name).ToList();
            }
            return PartialView(m);
        }
        public PartialViewResult _PartialDesignView()
        {
            List<EntertainmentAgency.Models.Design> m;
            using (ApplicationContext db = new ApplicationContext())
            {
                m = db.Designes.OrderBy(elem => elem.typeOfEntertainment.Type).ToList();
            }
            return PartialView(m);
        }
        public PartialViewResult _PartialTypesView()
        {
            List<EntertainmentAgency.Models.TypeOfEntertainment> m;
            using (ApplicationContext db = new ApplicationContext())
            {
                m = db.TypeOfEntertainments.OrderBy(elem => elem.Type).ToList();
            }
            return PartialView(m);
        }
        public PartialViewResult _PartialCompetitionView()
        {
            List<EntertainmentAgency.Models.Competition> m;
            using (ApplicationContext db = new ApplicationContext())
            {
                m = db.Competitions.OrderBy(elem => elem.typeOfEntertainment.Type).ToList();
            }
            return PartialView(m);
        }
        public PartialViewResult _PartialCarouselView()
        {
            
            return PartialView();
        }
        
        public ActionResult StartPage()
        {
            return View();
        }

    }


}
