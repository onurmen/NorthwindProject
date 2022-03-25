using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindDAL;
using NorthwindEntities;

namespace NorthwindWebApplication.Controllers
{ 
    public class OrdersController : Controller
    {
       OrderDAL orderDAL = new OrderDAL();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOrder(Orders orders)
        {
            orderDAL.CreateOrders(orders);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteOrder(int id)
        {
            orderDAL.DeleteOrders(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditOrders(int id)
        {
            Orders order  = orderDAL.GetOrdersById(id);
            return View(order);
        }
        [HttpPost]
        public ActionResult EditOrders(Orders orders)
        {
            orderDAL.UpdateOrders(orders.OrderID, orders);
            return RedirectToAction("Index");
        }
    }






}
























  