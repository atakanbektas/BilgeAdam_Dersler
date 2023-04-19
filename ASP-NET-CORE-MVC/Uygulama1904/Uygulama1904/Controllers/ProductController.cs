using Microsoft.AspNetCore.Mvc;
using Uygulama1904.Models;

namespace Uygulama1904.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            return View(Product.Urunler);
        }

    }
}
