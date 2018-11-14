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
        public ActionResult Employeers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    return View(db.Employeers.ToList());
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        [HttpGet]
        public ActionResult AddCompetition()
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
        public ActionResult AddCompetition(Competition model, int Type)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    try
                    {
                        db.Competitions.Add(new Competition() { About = model.About, Name = model.Name,  Price = model.Price, typeOfEntertainment=db.TypeOfEntertainments.First(elem=> elem.Id==Type) });
                        db.SaveChanges();
                        return RedirectToAction("Competitions", "Auto", new { area = "Admin" });
                    }
                    catch
                    {
                        ViewBag.Error = "Unknow mistake";
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        [HttpGet]
        public ActionResult AddEmployeer()
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
        public ActionResult AddEmployeer(Employeer model)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    try
                    {
                        if (db.Employeers.FirstOrDefault(elem => elem.Email == model.Email) == null)
                            db.Employeers.Add(new Employeer() { Email = model.Email, Name = model.Name, Phone = model.Phone });
                        else
                        {
                            ViewBag.Error = "Email is in db";
                            return View();
                        }
                        db.SaveChanges();
                        return RedirectToAction("Employeers","Auto",new { area="Admin"});
                    }
                    catch
                    {
                        ViewBag.Error = "Unknow mistake";
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        [HttpGet]
        public ActionResult AddMenu()
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
        public ActionResult AddMenu(Menu model)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    try
                    {
                        db.Menu.Add(new Menu() { Image = model.Image, Name = model.Name, About = model.About, Price=model.Price });
                        db.SaveChanges();
                        return RedirectToAction("Menus", "Auto", new { area = "Admin" });
                    }
                    catch
                    {
                        ViewBag.Error = "Unknow mistake";
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        [HttpGet]
        public ActionResult AddDesign()
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
        public ActionResult AddDesign(Design model, int Type)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    try
                    {
                        db.Designes.Add(new Design() { Img = model.Img, Price=model.Price, typeOfEntertainment=db.TypeOfEntertainments.First(elem => elem.Id==Type) });
                        db.SaveChanges();
                        return RedirectToAction("Designs", "Auto", new { area = "Admin" });
                    }
                    catch
                    {
                        ViewBag.Error = "Unknow mistake";
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        [HttpGet]
        public ActionResult AddType()
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
        public PartialViewResult _PartialType()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return PartialView(db.TypeOfEntertainments.ToList());
            }
        }
        public ActionResult AddType(TypeOfEntertainment model)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    try
                    {
                        db.TypeOfEntertainments.Add(new TypeOfEntertainment() { Img = model.Img, Type = model.Type });
                        db.SaveChanges();
                        return RedirectToAction("TypesOfEntertainment", "Auto", new { area = "Admin" });
                    }
                    catch
                    {
                        ViewBag.Error = "Unknow mistake";
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
        }
        public PartialViewResult _PartialCompetition()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return PartialView(db.Competitions.ToList());
            }
        }
        public PartialViewResult _PartialEmployeer()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return PartialView(db.Employeers.ToList());
            }
        }
        [HttpGet]
        public ActionResult AddCompetitionToEmployeer()
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
        public ActionResult AddCompetitionToEmployeer(int Employeer, int Competition)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (User.Identity.IsAuthenticated && db.Users.FirstOrDefault(elem => elem.UserName == User.Identity.Name).MyRole == MyRoles.Admin)
                {
                    try
                    {
                        db.Employeers.First(elem => elem.Id==Employeer).Competitions.Add(db.Competitions.First(elem => elem.Id==Competition));
                        db.SaveChanges();
                        return RedirectToAction("Employeers", "Auto", new { area = "Admin" });
                    }
                    catch
                    {
                        ViewBag.Error = "Unknow mistake";
                        return View();
                    }

                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }

        }
    }

}