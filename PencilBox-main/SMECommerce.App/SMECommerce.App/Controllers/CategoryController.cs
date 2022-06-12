using Microsoft.AspNetCore.Mvc;
using SMECommerce.App.Models.CategoryModels;
using SMECommerce.Models.EntityModels;
using SMECommerce.Repositorie;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(CategoryCreate model)
        {
            CategoryRepository categoryRepository = new CategoryRepository();

            if (model.Name != null)
            {
                var category = new Category()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Code = model.Code
                };

                var isAdded = categoryRepository.Add(category); 

                if(isAdded)
                {
                    return View("Success");
                }
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
