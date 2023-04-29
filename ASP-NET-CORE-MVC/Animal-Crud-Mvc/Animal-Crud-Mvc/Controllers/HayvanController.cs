using Animal_Crud_Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Animal_Crud_Mvc.Controllers
{
    public class HayvanController : Controller
    {
        private readonly HayvanContext _context;

        public HayvanController(HayvanContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var hayvanlar = _context.Hayvanlar.ToList();
            return View(hayvanlar);
        }
    }
}
