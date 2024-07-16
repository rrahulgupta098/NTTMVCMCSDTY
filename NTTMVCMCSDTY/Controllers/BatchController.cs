using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTTMVCMCSDTY.Controllers
{
    public class BatchController : Controller
    {
        // GET: Batch
        [HttpGet]
        public ActionResult DeleteBatch(long ID)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.DeleteBatch(ID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Index()
        {
            DataAccessLayer dal = new DataAccessLayer();
            // List<Batchvm> lst = dal.GetBatchData();
            //ViewBag.Lst = lst;
            ListBatchvm model = new ListBatchvm();
            model.Lst = dal.GetBatchData();
            return View(model);
        }


    }
}