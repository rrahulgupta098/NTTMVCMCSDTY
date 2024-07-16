using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        /*public ActionResult Index()
        {
            return View();
        }*/
        [HttpGet]
        public ActionResult Authenticate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authenticate(string un, string pwd)
        {
            DataAccessLayer dal = new DataAccessLayer();
            /* if(un =="rahul" && pwd == "rahul")
            {
                return RedirectToAction("index","Home");
            }
            else
            {
                ViewBag.ErrMsg = "LoginFailed";
                return View();
            }*/
            bool res = dal.Authenticate(un, pwd);
            if (res == false)
            {
                ViewBag.ErrMsg = "LoginFailed";
                return View();

            }
            else
            {
                return RedirectToAction("index", "ADMIN_DASHBOARD");
            }

        }
    }
}