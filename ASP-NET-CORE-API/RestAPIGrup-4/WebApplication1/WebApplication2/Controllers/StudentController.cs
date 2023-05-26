using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static List<Student> Students = new();

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
