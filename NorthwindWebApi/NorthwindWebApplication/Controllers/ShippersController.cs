using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindDAL;
using NorthwindEntities;


namespace NorthwindWebApplication.Controllers
{
    public class ShippersController : Controller
    {
        ShippersDAL shippersDAL = new ShippersDAL();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddShippers()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddShippers(Shippers shippers)
        {
            shippersDAL.CreateShipper(shippers);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteShippers(int id)
        {
            shippersDAL.DeleteShipper(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditShippers(int id)
        {
            Shippers shippers = shippersDAL.GetShipperById(id);
            return View(shippers);
        }
        [HttpPost]
        public ActionResult EditShippers(Shippers shippers)
        {
            shippersDAL.UpdateShipper(shippers.ShipperID, shippers);
            return RedirectToAction("Index");
        }
    }
}