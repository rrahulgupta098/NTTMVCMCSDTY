using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class Add_Training_ModuleController : Controller
    {
        // GET: Add_Training_Module
        [HttpGet]
        public ActionResult Index()
        {
            DataAccessLayer dal = new DataAccessLayer();
            AddModuleInfo model = new AddModuleInfo();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(AddModuleInfo model)
        {
            AddModuleInfo avm = new AddModuleInfo();
            avm.ID = model.ID;
            avm.Module_Name = model.Module_Name;
            DataAccessLayer dal = new DataAccessLayer();
            bool flag = dal.AddModule(avm);
            if(flag == true)
            {
                ViewBag.Msg = "Add Successfully";
            }
            else
            {
                ViewBag.Msg = "Failed To Added";
            }
            return View(model);
        }

       

    }
}