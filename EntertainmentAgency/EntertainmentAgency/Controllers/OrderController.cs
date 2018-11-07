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
    }
}