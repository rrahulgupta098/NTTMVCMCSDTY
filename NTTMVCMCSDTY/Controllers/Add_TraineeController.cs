using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class Add_TraineeController : Controller
    {
        // GET: Add_Trainee

        [HttpGet]
        public ActionResult Index()
        {
            DataAccessLayer dal = new DataAccessLayer();
            AddTraineeInfo model = new AddTraineeInfo();
            return View(model);
        }

        [HttpPost]

        public ActionResult Index(AddTraineeInfo model)
        {
            AddTraineeInfo atm = new AddTraineeInfo();
            atm.Name = model.Name;
            
            DataAccessLayer dal = new DataAccessLayer();
            bool flag = dal.Addtrainee(atm);
            if(flag == true)
            {
                ViewBag.Msg = "Add Successfully";
            }
            else
            {
                ViewBag.Msg = "Failed";
            }
            return View(model);
        }
    }
}