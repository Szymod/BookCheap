using BookCheap.Busines.DomainModel;
using BookCheap.Persistence.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookCheap.Clients.WebClient.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {

            if (ModelState.IsValid)
            {
                var v = db.Users.Where(a => a.Login.Equals(user.Login)).FirstOrDefault();

                if (v == null)
                {
                    user.SetPassword(user.Password);
                    db.Users.Add(user);
                    db.SaveChanges();
                    ModelState.Clear();
                    user = null;
                }
                else
                {
                    ViewBag.message = "Użytkownik o podanym loginie już istnieje.";
                    return View("~/Views/Home/Register.cshtml");
                }
            }

            return View();
        }
    }
}