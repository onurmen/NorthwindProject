using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindDAL;
using NorthwindEntities;

namespace NorthwindWebApplication.Controllers
{
    public class SuppliersController : Controller
    {

        SuppliersDAL suppliersDAL = new SuppliersDAL();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddSuppliers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSuppliers(Suppliers suppliers)
        {
            suppliersDAL.CreateSupplier(suppliers);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSuppliers(int id)
        {
            suppliersDAL.DeleteSuppliers(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditSuppliers(int id)
        {
            Suppliers suppliers = suppliersDAL.GetSupplierById(id);
            return View(suppliers);
        }
        [HttpPost]
        public ActionResult EditSuppliers(Suppliers suppliers)
        {
            suppliersDAL.UpdateSuppliers(suppliers.SuppliersID, suppliers);
            return RedirectToAction("Index");
        }
    }
}
