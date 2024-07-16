using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class ADMIN_DASHBOARDController : Controller
    {
        // GET: ADMIN_DASHBOARD
        [HttpGet]
       public ActionResult Index()
        {
            return View();
        }

       
        


    }
}