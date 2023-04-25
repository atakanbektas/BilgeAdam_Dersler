using Asp_Custom_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Custom_Product.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new()
        {
            new Product(){ProductId=1,Name="Iphone 12",Price=25000m}
        };
        public IActionResult Index()
        {

            return View();
        }
    }
}
