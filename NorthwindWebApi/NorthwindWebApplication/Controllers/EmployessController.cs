using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using NorthwindDAL;
using NorthwindEntities;

namespace NorthwindWebApplication.Controllers
{
    public class EmployessController : Controller
    {
        EmployessDAL employeesDAL = new EmployessDAL();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddEmployees()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployees(Employess employess)
        {
            employeesDAL.CreateEmployess(employess);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteEmployees(int id)
        {
            employeesDAL.DeleteEmployess(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditEmployess(int id)
        {
            Employess employess = employeesDAL.GetEmployessById(id);
            return View(employess);
        }
        [HttpPost]
        public ActionResult EditEmployess(Employess employess)
        {
            employeesDAL.UpdateEmployess(employess.EmployeeID, employess);
            return RedirectToAction("Index");
        }
    }
}

 










