using BookCheap.Busines.DomainModel;
using BookCheap.Clients.WebClient.App_Start;
using BookCheap.Persistence.DataAccess;
using BookCheap.Common.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Newtonsoft.Json;
using BookCheap.Clients.WebClient.Models;

namespace BookCheap.Clients.WebClient.Controllers
{
    public class HomeController : BaseController
    {
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
                var response = Request["g-recaptcha-response"];

                string secret = System.Configuration.ConfigurationManager.AppSettings["Secret-Key-ReCaptcha"];

                var client = new System.Net.WebClient();
                var reply =
                    client.DownloadString(
                        string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}",
                    secret, response));

                var captchaResponse = JsonConvert.DeserializeObject<CaptchaResponse>(reply);

                //if (!captchaResponse.Success)
                //{
                //    if (captchaResponse.ErrorCodes.Count <= 0) return View();

                //    var error = captchaResponse.ErrorCodes[0].ToLower();
                //    switch (error)
                //    {
                //        case ("missing-input-secret"):
                //            ViewBag.Message = "Brak parametru";
                //            break;
                //        case ("invalid-input-secret"):
                //            ViewBag.Message = "Parametr nieprawidłowy";
                //            break;

                //        case ("missing-input-response"):
                //            ViewBag.Message = "Brak odpowiedzi";
                //            break;
                //        case ("invalid-input-response"):
                //            ViewBag.Message = "Odpowiedź nieprawidłowa";
                //            break;

                //        default:
                //            ViewBag.Message = "Wystąpił problem. Spróbuj ponownie";
                //            break;
                //    }
                //}

                //else
                //{

                    var v = UnitOfWork.Users.GetAll().Where(a => a.Login.Equals(user.Login)).FirstOrDefault();

                    if (v == null)
                    {
                        PasswordHash.CreateHash(user.Password);
                        UnitOfWork.Users.Add(user);
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
        

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if(ModelState.IsValid)
            {
                PasswordHash.CreateHash(user.Password);
                var v = UnitOfWork.Users.GetAll().Where(a => a.Login.Equals(user.Login) && a.Password.Equals(user.Password)).FirstOrDefault();
                if(v!=null)
                {
                    if (user.IsBlocked == false)
                    {
                        Session["LoggedUser"] = v;
                        FormsAuthentication.SetAuthCookie(v.Login, false);
                        return RedirectToAction("AfterLogin");
                    }
                    else
                    {
                        ViewBag.Message = "Użytkownik zablokowany.";
                        return View(user);
                    }

                }
                else
                {
                    ViewBag.Message = "Niepoprawne dane logowania.";
                    return View(user);
                }
            }

            return View(user);
        }

        public ActionResult AfterLogin()
        {
            if(Session["LoggedUser"] !=null)
            {
                return View();
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
    }
}