using EntertainmentAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntertainmentAgency.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View("Index");
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

        public PartialViewResult _PartialDesignView(int id)
        {
            ViewBag.IDTypeEntertainment = id;
            List<EntertainmentAgency.Models.Design> m;
            using (ApplicationContext db = new ApplicationContext())
            {
                m = db.Designes.OrderBy(elem => elem.typeOfEntertainment.Type).Where(elem => elem.typeOfEntertainment.Id == id).ToList();
            }
            return PartialView(m);
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
        public PartialViewResult _PartialCompetitionView()
        {
            List<EntertainmentAgency.Models.Competition> m;
            using (ApplicationContext db = new ApplicationContext())
            {
                m = db.Competitions.OrderBy(elem => elem.Name).ToList();
            }
            return PartialView(m);
        }
    }
}