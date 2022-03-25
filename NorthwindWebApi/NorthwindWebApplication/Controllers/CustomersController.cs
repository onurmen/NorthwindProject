using NorthwindDAL;
using NorthwindEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindWebApplication.Controllers
{
    public class CustomersController : Controller
    {
        CustomersDAL customersDAL = new CustomersDAL();
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customers customers)
        {
            customersDAL.CreateCustomer(customers);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCustomer(int id)
        {
            customersDAL.DeleteCustomer(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCustomer(int id)
        {
            Customers customers = customersDAL.GetCustomerById(id);
            return View(customers);
        }
        [HttpPost]
        public ActionResult EditCustomer(Customers customers)
        {
            customersDAL.UpdateCustomer(customers.CustomerID, customers);
            return RedirectToAction("Index");
        }
    }
}