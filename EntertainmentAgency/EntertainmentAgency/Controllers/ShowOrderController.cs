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
            ViewBag.Id = IdOrder;
            return View();
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
            return PartialView();
        }
        public PartialViewResult _PartialMenuView()
        {
            return PartialView();
        }
        public PartialViewResult _PartialDesignView()
        {
            return PartialView();
        }
    }
}