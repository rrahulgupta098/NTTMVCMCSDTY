using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class Trainee_DetailsController : Controller
    {

        public ActionResult EditTrainee(long ID)
        {
            AddTraineeInfo model = new AddTraineeInfo();
            DataAccessLayer dal = new DataAccessLayer();
            Traineevm tinfo = dal.GetTraineeDetails(ID);
            if (tinfo != null)
            {
                model.ID = tinfo.ID;
                model.Name = tinfo.Name;
                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        /*  [HttpGet]
          public ActionResult EditTrainee(long ID)
          {
              AddTraineeInfo model = new AddTraineeInfo();
              DataAccessLayer dal = new DataAccessLayer();
              Traineevm tinfo = dal.GetTraineeDetails(ID);
              if (tinfo != null)
              {
                  model.ID = tinfo.ID;
                  model.Name = tinfo.Name;
                  return View(model);
              }
              else
              {
                  return RedirectToAction("Index");
              }
          }*/

         [HttpPost]

         public ActionResult EditTrainee(AddTraineeInfo model)
         {
             DataAccessLayer dal = new DataAccessLayer();
             Traineevm tvm = new Traineevm();
             tvm.ID = model.ID;
             tvm.Name = model.Name;
             dal.EditTrainee(tvm);
             return RedirectToAction("Index");
         }

        [HttpGet]
        public ActionResult DeleteTrainee(long ID)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.DeleteTrainee(ID);
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            DataAccessLayer dal = new DataAccessLayer();
            // List<Traineevm> lst = dal.GetTraineeData();
            //ViewBag.Lst = lst;
            ListTraineevm model = new ListTraineevm();
            model.Lst = dal.GetTraineeData();
            return View(model);
        }

       
    }
}