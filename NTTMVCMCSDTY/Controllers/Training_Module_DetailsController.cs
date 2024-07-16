using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class Training_Module_DetailsController : Controller
    {
        // GET: Training_Module_Details\
        [HttpGet]
        public ActionResult EditModule(long ID)
        {
            AddModuleInfo model = new AddModuleInfo();
            DataAccessLayer dal = new DataAccessLayer();
            Modulevm minfo = dal.GetModuleDetails(ID);
            if (minfo != null)
            {
                model.ID = minfo.ID;
                model.Module_Name = minfo.Module_Name;
                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]

        public ActionResult EditModule(AddModuleInfo model)
        {
            DataAccessLayer dal = new DataAccessLayer();
            Modulevm minfo = new Modulevm();
            minfo.ID = model.ID;
            minfo.Module_Name = model.Module_Name;
            dal.EditModule(minfo);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteModule(long ID)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.DeleteModule(ID);
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            DataAccessLayer dal = new DataAccessLayer();
            //List<Modulevm> lst = dal.GetModuleData();
            // ViewBag.Lst = lst;
            ListModulevm model = new ListModulevm();
            model.Lst = dal.GetModuleData();
            return View(model);
        }
       

        }
    }