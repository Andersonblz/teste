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
            new List<Category>() {
                new Category() { CategoryId = 1, Name = "Keyboard" },
                new Category() { CategoryId = 2, Name = "Monitor" },
                new Category() { CategoryId = 3, Name = "Notebook" },
                new Category() { CategoryId = 4, Name = "Mouse" },
                new Category() { CategoryId = 5, Name = "Printers" }
            };


        // GET: Categories
        public ActionResult Index()
        {

            // SELECT * 
            // FROM categories
            // ORDER BY name



            return View(categoryList
                .OrderBy(c => c.Name));
        }
        private string Nome(Category c) {
            {
                return c.Name;
            }
        }
    }
    
