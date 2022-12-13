using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Hotel_Project.Models;
using Microsoft.SqlServer.Server;

namespace Hotel_Project.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {

        // GET: Account

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(User user)
        {
            using (HotelEntities1 db = new HotelEntities1())
            {
                var result = db.UserMasters.Where(x => x.Userid == user.Username && x.Password1 == user.Password1);
                if (result.Count() != 0)
                {
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    //session["userıd]= user.username;
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    TempData["msg"] = "hatalı";
                }
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return View("Login");
        }
        
    }
}