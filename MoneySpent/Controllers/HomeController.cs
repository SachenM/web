using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoneySpent.Models;

namespace MoneySpent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            UserContext Users = new UserContext();

            int id = 1;
            //User selectedUser = Users.UserList.Single(user => user.UserId == id);

            List< User> selectedUser = Users.UserList.ToList();

            return View(selectedUser);
        }


        public ActionResult Entry()
        {
            return View();
        }

        public ActionResult Transfer()
        {
            return View();
        }

        public ActionResult Service()
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
    }
}