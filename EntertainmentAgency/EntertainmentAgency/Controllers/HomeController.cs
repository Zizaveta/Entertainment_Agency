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
                m = db.Menu.ToList();
            }
            return PartialView(m);
        }
        
    }


}
