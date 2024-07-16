using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class Add_TrainerController : Controller
    {
        // GET: Add_Trainer
        [HttpGet]
        public ActionResult Index()
        {
            DataAccessLayer dal = new DataAccessLayer();
            AddTrainerinfo model = new AddTrainerinfo();
            return View(model);
        }

       [HttpPost]
        public ActionResult Index(AddTrainerinfo model)
        {
            AddTrainerinfo tvm = new AddTrainerinfo();
            tvm.ID = model.ID;
            tvm.Name = model.Name;
            tvm.Skill = model.Skill;
            DataAccessLayer dal = new DataAccessLayer();
            bool flag = dal.Addtrainer(tvm);
            if(flag == true)
            {
                ViewBag.Msg = "Added Successfully";
            }
            else
            {
                ViewBag.Msg = "Failed to Added";
            }
            return View(model);
        }
       

    }
}