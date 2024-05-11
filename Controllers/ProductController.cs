using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AmsT4_Carousel.Models;

namespace AmsT4_Carousel.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDataContext _context;

        public ProductController(ApplicationDataContext context)
        {
            _context = context;
        }

        // GET: Products
        public IActionResult ProductList()
        {

            var product = _context.Products.ToList();

            return View(product);
                          
        }

       

      
        public IActionResult AddProduct()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult AddProduct(Product product)
        {
            
            {
                product.Id = Guid.NewGuid();
                _context.Add(product);
                _context.SaveChangesAsync();
                return RedirectToAction(nameof(ProductList));
            }
            
        }

      
    }
}
