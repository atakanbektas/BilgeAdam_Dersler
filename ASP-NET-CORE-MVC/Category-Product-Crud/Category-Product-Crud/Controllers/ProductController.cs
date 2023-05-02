using Category_Product_Crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace Category_Product_Crud.Controllers
{
    public class ProductController : Controller
    {
        private readonly MyContext _context;

        public ProductController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var product = _context.Products.ToList();
            return View();
        }
    }
}
