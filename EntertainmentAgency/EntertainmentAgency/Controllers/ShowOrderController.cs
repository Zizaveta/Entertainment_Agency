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
            return View();
        }
        public PartialViewResult _PartialTypeView()
        {
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