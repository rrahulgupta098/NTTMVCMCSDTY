using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class Trainer_DetailsController : Controller
    {
        // GET: Trainer_Details
        [HttpGet]
        public ActionResult EditTrainer(long ID)
        {
            AddTrainerinfo model = new AddTrainerinfo();
            DataAccessLayer dal = new DataAccessLayer();
            Trainervm tinfo = dal.GetTrainerDetails(ID);
            if(tinfo != null)
            {
                model.ID = tinfo.ID;
                model.Name = tinfo.Name;
                model.Skill = tinfo.Skill;
                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public ActionResult EditTrainer(AddTrainerinfo model)
        {
            DataAccessLayer dal = new DataAccessLayer();
            Trainervm tinfo = new Trainervm();
            tinfo.ID = model.ID;
            tinfo.Name = model.Name;
            tinfo.Skill = model.Skill;
            dal.EditTrainer(tinfo);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteTrainer(long ID)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.DeleteTrainer(ID);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Index()
        {
            DataAccessLayer dal = new DataAccessLayer();
            //List<Trainervm> lst = dal.GetTrainerData();
            ListTrainervm model = new ListTrainervm();
            model.Lst = dal.GetTrainerData();
           // ViewBag.Lst = lst;
            return View(model);
         
        }
    }
}