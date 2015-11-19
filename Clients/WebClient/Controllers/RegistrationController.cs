using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BookCheap.Persistence.DataAccess;
using BookCheap.Busines.DomainModel;


namespace BookCheap.Clients.WebClient.Controllers
{
    public class RegistrationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User user)
        {

            if (ModelState.IsValid)
            {
                user.SetPassword(user.Password);
                db.Users.Add(user);
                db.SaveChanges();
                ModelState.Clear();
                user = null;
            }

            return View("~/Views/Home/Index.cshtml");
        }
    }
}