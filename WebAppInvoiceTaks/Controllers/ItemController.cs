using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppInvoiceTaks.Models;
namespace WebAppInvoiceTaks.Controllers
{
    public class ItemController : Controller
    {

        invoiceDBEntities db;
        public ItemController()
        {
            db = new invoiceDBEntities();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string AddItem(tblItem i)
        {

            db.tblItems.Add(i);
            db.SaveChanges();
            return "Item Added Successfully";
        }

        public JsonResult GetItems()
        {
            List<tblItem> lst = new List<tblItem>();
            foreach(tblItem i in db.tblItems.ToList())
            {
                i.tblInvoiceItems.Clear();
          
                lst.Add(i);
                
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
	}
}