using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class Add_BatchController : Controller
    {
        // GET: Add_Batch
        [HttpGet]
        public ActionResult Index()
        {
            DataAccessLayer dal = new DataAccessLayer();
            AddBatchInfo model = new AddBatchInfo();
           
            List<AddTrainerinfo> lst = dal.GetTrainerName();
            var Seltrname = lst.Select(obj => new SelectListItem() { Text = obj.Name, Value = obj.ID.ToString() }).ToList();
            model.TrNameLst = Seltrname;

            List<AddModuleInfo> lst1 = dal.GetModuleName();
           var SelModuleNameList = lst1.Select(obj => new SelectListItem() { Text = obj.Module_Name, Value = obj.ID.ToString() }).ToList();
            model.ModuleNameLst = SelModuleNameList;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(AddBatchInfo model)
        {
            AddBatchInfo abm = new AddBatchInfo();
            abm.BatchID = model.BatchID;
            abm.StartDate = model.StartDate;
            abm.EndDate = model.EndDate;
            abm.TrainerId = model.TrainerId;
            abm.TrainingModule = model.TrainingModule;
            DataAccessLayer dal = new DataAccessLayer();
            bool flag = dal.AddBatch(abm);
            if (flag == true)
            {
                ViewBag.Msg = "Added Successfully";
            }
            else
            {
                ViewBag.Msg = "Failed";
                return View("Index");
            }
            return View(model);
        }

      
       
       
    }
}