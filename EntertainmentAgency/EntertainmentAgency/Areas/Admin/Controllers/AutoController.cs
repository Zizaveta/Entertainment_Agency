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
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
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
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        public ActionResult Menus()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    return View(db.Menu.ToList());
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        public ActionResult Competitions()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    return View(db.Competitions.ToList());
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        public ActionResult TypesOfEntertainment()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    return View(db.TypeOfEntertainments.ToList());
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        public ActionResult Designs()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    return View(db.Designes.ToList());
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
    }

}