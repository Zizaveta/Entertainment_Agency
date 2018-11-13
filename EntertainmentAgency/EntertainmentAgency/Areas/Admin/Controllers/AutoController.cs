using EntertainmentAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntertainmentAgency.Areas.Admin.Controllers
{
    public class AutoController : Controller
    {
        // GET: Admin/Auto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Persons()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    return View(db.Users.Where(elem => elem.MyRole != MyRoles.Admin).ToList());
                }
                else
                {
                    return Redirect("Home/Index");
                }
            }
        }
    }
}