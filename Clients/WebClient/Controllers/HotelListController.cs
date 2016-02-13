using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookCheap.Busines.DomainModel;
using BookCheap.Clients.WebClient.App_Start;
using BookCheap.Persistence.DataAccess;
using PagedList;

namespace BookCheap.Clients.WebClient.Controllers
{
    public class HotelListController : BaseController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HotelList
        public ActionResult Index(int? page, string sortOrder)
        {
            int currentPage = page ?? 1;
            int pageSize = 5;

            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSort = String.IsNullOrEmpty(sortOrder) ? "" : "Name";
            ViewBag.RatingSort = String.IsNullOrEmpty(sortOrder) ? "RatingAsc" : "Rating";

            var hotels = UnitOfWork.Hotels.GetAll().OrderBy(n => n.Name);

            switch (sortOrder)
            {
                //case "Rating":
                //    hotels.OrderByDescending(s => s.Rating);
                //    break;

                //case "RatingAsc":
                //    hotels.OrderBy(s => s.Rating);
                //    break;

                case "Name": 
                    hotels.OrderByDescending(s => s.Name);
                    break;

                default:
                    hotels.OrderBy(s => s.Name);
                    break;
            }

            return View(hotels.ToPagedList<Hotel>(currentPage,pageSize));
        }

        public ActionResult Application()
        {

            return View();
        }

        public ActionResult Application(Application application)
        {
            if (ModelState.IsValid)
            {
                //formularz przeszedł
            }

            return View(application);
        }
    }
}