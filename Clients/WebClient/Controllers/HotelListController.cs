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
    public class HotelListController : BaseController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HotelList
        public ActionResult Index(int? page)
        {
            int currentPage = page ?? 1;
            int pageSize = 10;
            var hotels = db.Hotels.Skip((page.Value - 1) * pageSize).Take(pageSize);
            return View(hotels);
        }
    }
}