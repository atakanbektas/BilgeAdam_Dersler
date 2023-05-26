using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public static List<Users> users;
        public IActionResult Index()
        {
            return View();
        }

    }
}
