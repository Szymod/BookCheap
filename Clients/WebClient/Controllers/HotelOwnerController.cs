using BookCheap.Clients.WebClient.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookCheap.Clients.WebClient.Controllers
{
    public class HotelOwnerController : BaseController
    {
        // GET: HotelOwner
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostFile()
        {
            return Json(1);
        }
    }
}