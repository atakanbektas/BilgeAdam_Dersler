using Microsoft.AspNetCore.Mvc;
using WebSayiGirisi.Models;

namespace WebSayiGirisi.Controllers
{
    public class MyNumberController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(MyNumber numbers)
        //{
        //    if (numbers.LowerNumber < numbers.UpperNumber)
        //    {
        //        return Ok("Girilen Sayilar Uygun");
        //    }
        //    return BadRequest("Format uygun değil");
        //}

        [HttpPost]
        public IActionResult Index(MyNumber numbers)
        {
            ViewBag.diff = numbers.UpperNumber - numbers.LowerNumber;

            if (ViewBag.diff <= 0)
            {
                ViewBag.msg = "Format uygun değil";
            }
            else
            {
                ViewBag.msg = null;
            }
            return View();
        }
    }
}
