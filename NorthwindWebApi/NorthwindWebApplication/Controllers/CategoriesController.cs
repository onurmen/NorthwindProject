using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindDAL;
using NorthwindEntities;

namespace NorthwindWebApplication.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesDAL categoriesDAL = new CategoriesDAL();
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCategori()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategori(Categories categories)
        {
            categoriesDAL.CreateCategories(categories);
            return RedirectToAction("Index");
        }
        public ActionResult Deletecategories(int id)
        {
            categoriesDAL.DeleteCategories(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategories(int id)
        {
            Categories categories = categoriesDAL.GetCategoriesById(id);
            return View(categories);
        }
        [HttpPost]
        public ActionResult EditCategories(Categories categories)
        {
            categoriesDAL.UpdateCategories(categories.CategoriesID, categories);
            return RedirectToAction("Index");
        }
    }
}
