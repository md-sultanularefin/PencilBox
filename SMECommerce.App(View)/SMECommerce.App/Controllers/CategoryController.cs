using Microsoft.AspNetCore.Mvc;
using SMECommerce.App.Models.CategoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMECommerce.App.Controllers
{
    public class CategoryController : Controller
    {
        public string Index()
        {
            return "This is the default Controller";
        }

        public IActionResult Create(CategoryCreate categoryCreate)
        {
            if( categoryCreate.Name !=null)
            {
                return View("Success");
            }
            return View();
        }
        public string CategoryListCreate(CategoryCreate[] categories)
        {
            string data = "Category List Create" + Environment.NewLine;
            if (categories != null && categories.Any())
            {
                foreach (var category in categories)
                {
                    data += $"Category Create: {category.Name} Code: {category.Code}" + Environment.NewLine;
                }
            }

            return data;
        }
    }
}
