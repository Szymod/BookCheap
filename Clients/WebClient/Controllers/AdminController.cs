using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookCheap.Busines.DomainModel;
using BookCheap.Persistence.DataAccess;
using BookCheap.Clients.WebClient.App_Start;
using BookCheap.Clients.WebClient.Code;

namespace BookCheap.Clients.WebClient.Controllers
{
    [AdminAuthorize]
    public class AdminController : BaseController
    {
        // GET: /Admin/
        public ActionResult Index()
        {
            return View(UnitOfWork.Users.GetAll().ToList());
        }

        // GET: /Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = UnitOfWork.Users.GetById(id.Value);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: /Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="UserId,Firstname,Lastname,Login,Password,Email,Phone,IsAdmin,IsBlocked")] User user)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.Users.Add(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: /Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = UnitOfWork.Users.GetById(id.Value);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: /Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="UserId,Firstname,Lastname,Login,Password,Email,Phone,IsAdmin,IsBlocked")] User user)
        {
            if (ModelState.IsValid)
            {
                UnitOfWork.Users.Update(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: /Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = UnitOfWork.Users.GetById(id.Value);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: /Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = UnitOfWork.Users.GetById(id);
            UnitOfWork.Users.Delete(user);
            return RedirectToAction("Index");
        }

         public ActionResult HotelTypeList()
        {

           return View();
       }
     public ActionResult RoomTypeList()
       {

            return View();
        }

     public ActionResult DeleteHotelType(int id)
     {
         HotelType htype = db.HotelType.Find(id);
         db.Tag.Remove(htype);
         db.SaveChanges();
         return RedirectToAction("HotelTypeList");
     }

       public ActionResult HotelTypeCreate([Bind(Include = "Name")] HotelType htype)
        {
            if (ModelState.IsValid)
            {
                db.HotelType.Add(htype);
                db.SaveChanges();
               return RedirectToAction("HotelTypeList");
           }

           return View(htype);
       }

       public ActionResult DeleteRoomType(int id)
       {
           RoomType rtype = db.RoomType.Find(id);
           db.RoomType.Remove(rtype);
           db.SaveChanges();
           return RedirectToAction("RoomTypeList");
       }

       public ActionResult RoomTypeCreate([Bind(Include = "Name")] RoomType rtype)
       {
           if (ModelState.IsValid)
           {
               db.RoomType.Add(rtype);
               db.SaveChanges();
               return RedirectToAction("RoomTypeList");
           }

           return View(rtype);
       }
      
    }
}
