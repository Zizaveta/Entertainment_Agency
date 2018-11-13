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
            if (User.Identity.IsAuthenticated)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    try
                    {
                        db.PriceLists.First(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit);
                        ViewBag.Order = "Continue your order";
                    }
                    catch
                    {
                        db.PriceLists.Add(new PriceList() { user = db.Users.First(elem => elem.UserName == User.Identity.Name), StatusOfOrder = StatusOfOrder.Edit, Price = 0 });
                        db.SaveChanges();
                        ViewBag.Order = "Create your order";
                    }
                }
            }
            else
            {
                ViewBag.Order = "Please, authorize to create order";
            }
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
      
        public PartialViewResult _PartialDesignView(int id=0)
        {
            List<EntertainmentAgency.Models.Design> m;
            using (ApplicationContext db = new ApplicationContext())
            {
                if(id!=0)
                {
                    db.PriceLists.FirstOrDefault(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit).TypeOfEntertainment = db.TypeOfEntertainments.FirstOrDefault(elem => elem.Id == id);
                    db.SaveChanges();
                }
                m = db.Designes.Where(elem => elem.typeOfEntertainment.Id == db.PriceLists.FirstOrDefault(elem2=> elem2.user.UserName==User.Identity.Name && elem2.StatusOfOrder==StatusOfOrder.Edit).TypeOfEntertainment.Id).OrderBy(elem => elem.typeOfEntertainment.Type).ToList();
            }
            return PartialView(m);
        }
        public ActionResult _PartialMenuView(int id=0)
        {
            List<EntertainmentAgency.Models.Menu> m;
            using (ApplicationContext db = new ApplicationContext())
            {
                if(id!=0)
                {
                    db.PriceLists.FirstOrDefault(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit).design = db.Designes.FirstOrDefault(elem => elem.Id == id);
                    db.SaveChanges();
                }
                m = db.Menu.OrderBy(elem => elem.Name).ToList();
            }
            return PartialView(m);
        }
        public PartialViewResult _PartialCompetitionView()
        {
            List<EntertainmentAgency.Models.Competition> m;
            using (ApplicationContext db = new ApplicationContext())
            {
                //m = db.Competitions.Where(elem => elem.typeOfEntertainment.Id == db.PriceLists.FirstOrDefault(elem2 => elem2.user.UserName == User.Identity.Name && elem2.StatusOfOrder == StatusOfOrder.Edit).Id).OrderBy(elem => elem.Name).ToList();
                m = db.Competitions.ToList();
            }
            return PartialView(m);
        }
        [HttpPost]
        public ActionResult AddMenu(int Id, int Count)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (db.PriceLists.FirstOrDefault(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit).menu.FirstOrDefault(elem => elem.Menu.Id == Id) != null)
                {
                    db.PriceLists.FirstOrDefault(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit).menu.FirstOrDefault(elem => elem.Menu.Id == Id).Q_ty += Count;
                }
                else
                    db.PriceLists.FirstOrDefault(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit).menu.Add(new MenuCount() { Menu=db.Menu.FirstOrDefault(elem => elem.Id==Id), Q_ty=Count });
                db.SaveChanges();
            }
            return View("Index");
        }
        [HttpPost]
        public ActionResult AddCompetition(int Id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if(db.PriceLists.FirstOrDefault(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit).Competitions.FirstOrDefault(elem => elem.Id == Id) == null)
                {
                    db.PriceLists.FirstOrDefault(elem => elem.user.UserName == User.Identity.Name && elem.StatusOfOrder == StatusOfOrder.Edit).Competitions.Add(db.Competitions.First(elem => elem.Id == Id));
                    db.SaveChanges();
                }
            }
                return View("Index");
        }
        public PartialViewResult _LoadItems()
        {
            return PartialView();
        }
    }
}