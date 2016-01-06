using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookCheap.Busines.DomainModel;
using BookCheap.Clients.WebClient.App_Start;
using BookCheap.Persistence.DataAccess;

namespace BookCheap.Clients.WebClient.Controllers
{
    public class HotelListController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HotelList
        public ActionResult Index()
        {
            return View(db.Hotels.ToList());
        }
    }
}