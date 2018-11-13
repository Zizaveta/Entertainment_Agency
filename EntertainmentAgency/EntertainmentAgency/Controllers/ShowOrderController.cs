using EntertainmentAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntertainmentAgency.Controllers
{
    public class ShowOrderController : Controller
    {
        // GET: ShowOrder
        public ActionResult Index(int IdOrder = 0)
        {
            return View("Index", IdOrder);
        }
        public PartialViewResult _PartialTypeView(int Id)
        {
            TypeOfEntertainment type;
            using (ApplicationContext db = new ApplicationContext())
            {
                if (Id != 0)
                    type = db.PriceLists.First(elem => elem.Id == Id).TypeOfEntertainment;
                else
                    type = db.PriceLists.First(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit).TypeOfEntertainment;
            }
            return PartialView("_PartialTypeView",type);
        }
        public PartialViewResult _PartialMenuView(int Id)
        {
            List<MenuCount> l;
            using (ApplicationContext db = new ApplicationContext())
            {
                if (Id != 0)
                {
                    l = db.PriceLists.First(elem => elem.Id == Id).menu.ToList();
                }
                else
                {
                    l = db.PriceLists.First(elem => elem.user.UserName==User.Identity.Name).menu.ToList();
                }
            }
            return PartialView("_PartialMenuView", l);
        }
        public PartialViewResult _PartialDesignView(int Id)
        {
            Design d;
            using (ApplicationContext db = new ApplicationContext())
            {
                if (Id != 0)
                {
                    d = db.PriceLists.First(elem => elem.Id == Id).design;
                }
                else
                {
                    d = db.PriceLists.First(elem => elem.user.UserName == User.Identity.Name).design;
                }
            }
            return PartialView("_PartialDesignView", d);
        }
        public PartialViewResult _PartialCompetitionView(int Id)
        {
            List<Competition> C;
            using (ApplicationContext db = new ApplicationContext())
            {
                if (Id != 0)
                    C = db.PriceLists.First(elem => elem.Id == Id).Competitions.ToList();
                else
                    C = db.PriceLists.First(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit).Competitions.ToList();
              
            }
                return PartialView("_PartialCompetitionView",C);
        }
        
        public PartialViewResult _PartialProduct(int Id)
        {
            Menu m;
            using (ApplicationContext db = new ApplicationContext())
            {
                m = db.Menu.First(elem => elem.Id == Id);
            }
            return PartialView("_PartialProduct", m);
        }
        public ActionResult SendOrder()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.PriceLists.First(elem => elem.StatusOfOrder == StatusOfOrder.Edit && elem.user.UserName == User.Identity.Name).StatusOfOrder = StatusOfOrder.Send;
                db.SaveChanges();
            }
            return View(Url.Action("Index","Home"));
        }
    }
}