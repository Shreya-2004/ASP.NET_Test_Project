using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    public class LoginController : Controller
    {
     
        // GET: Login
        public ActionResult login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult loginform( login loginuser)
        {
            string email = loginuser.Email;
            string Password =loginuser.Password;
            if (email == "abhishek.raut@gmail.com" && Password == "admin@12345")
            {
                ViewBag.Message = "LOGIN SUCCESSFULL";
            }
            else
            {
                ViewBag.Message = "Please enter valid Email ID and Password";

            }
            return View();
        }
 }


    
}