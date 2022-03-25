using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindDAL;
using NorthwindEntities;

namespace NorthwindWebApplication.Controllers
{
    public class ProductsController : Controller
    {
       ProductsDAL productsDAL = new ProductsDAL();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Products product)
        {
            productsDAL.CreateProduct(product);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int id)
        {
            productsDAL.DeleteProduct(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            Products product = productsDAL.GetProductById(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult EditProduct(Products product)
        {
            productsDAL.UpdateProduct(product.ProductsID, product);
            return RedirectToAction("Index");
        }
    }
}