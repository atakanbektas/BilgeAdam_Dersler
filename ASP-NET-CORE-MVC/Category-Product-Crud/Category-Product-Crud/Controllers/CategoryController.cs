using Category_Product_Crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace Category_Product_Crud.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyContext _context;

        public CategoryController(MyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }
    }
}
