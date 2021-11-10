using ClothBazaar.Entities;
using ClothBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazaar.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryServices categoryService = new CategoryServices();

        [HttpGet]
        public ActionResult Index()
        {
            var categories= categoryService.GetCategory();
         
            return View(categories);
        }

        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryService.SaveCategory(category);
                
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoryService.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryService.UpdateCategory(category);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = categoryService.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            
            categoryService.DeleteCategory(category.ID);

            return RedirectToAction("Index");
        }

    }


}