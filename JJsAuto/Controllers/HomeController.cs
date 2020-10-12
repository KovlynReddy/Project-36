using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JJsAuto.Models;

namespace JJsAuto.Controllers
{
    public class HomeController : Controller
    {
        dbModel model = new dbModel();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Staff user)
        {
            var staffUser = model.Staffs.Where(x => x.User_ID == user.User_ID && x.Password == user.Password).Count();

            if ( staffUser> 0 && user.Is_Admin == true)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            else if (staffUser > 0 && user.Is_Admin == false)
            {
                return RedirectToAction("Index","Repairs");
            }
            else
            {
                return View();
            }

        }
    }

}