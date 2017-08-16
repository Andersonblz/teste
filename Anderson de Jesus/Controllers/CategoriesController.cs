using Anderson_de_Jesus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anderson_de_Jesus.Controllers
{
    public class CategoriesController : Controller
    {
        private static IList<Category> categoryList =
            new List<Category>()
            {
                new Category() {CategoryId = 1, Name = "Keyboard" },
                new Category() {CategoryId = 2, Name = "Monitor" },
                new Category() {CategoryId = 3, Name = "Notebook" },
                new Category() {CategoryId = 4, Name = "Mouse" },
                 new Category() {CategoryId = 5, Name = "Printer" }
                 };

       


        // {CategoryId:0,Name:"Cat1"}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            categoryList.Add(category);

            category.CategoryId =
                categoryList.Max(c => c.CategoryId) + 1;
            return RedirectToAction("Create");
        }


        public ActionResult Edit(long id)
        {
            var category = categoryList
                .where(c => c.CategoryId == id)
                .First();

            return View(category);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category modified)
        {
            var category = categoryList
                .where(c => c.CategoryId == modified.CategoryId)
                .First();

            category.Name = modified.Name;
        

            return RedirectToAction("Index");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            var category = categoryList
                .where(c => c.CategoryId == id)
                .First();

            return View(category);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Category toDelete)
        {
            var category = categoryList
                .where(c => c.CategoryId == toDelete.CategoryId)
                .First();

            categoryList.Remove(category);



            return RedirectToAction("Index");

        }

        public ActionResult Details(long id)
        {
            var category = categoryList
                .where(c => c.CategoryId == id)
                .First();

            return View(category);

        }
    }
}