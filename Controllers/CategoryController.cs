using AMST4.Carousel.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmsT4_Carousel.Controllers
{
    public class CategoryController : Controller
    {

        private ApplicationDataContext _applicationDataContext;

        public CategoryController(ApplicationDataContext applicationDataContext)
        { _applicationDataContext = applicationDataContext; }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var categories = _applicationDataContext.Category.ToList();

            return View(categories);
        }

        public IActionResult AddCategory()
        { 
        
            return View();

        }

       [HttpPost]
        public IActionResult AddCategory(Category category)
        {

            _applicationDataContext.Category.Add(category);

            _applicationDataContext.SaveChanges();

            return CreatedAtRoute("CategoryList",
                new { Id = category.Id }, category);

        
        }
    }
}

