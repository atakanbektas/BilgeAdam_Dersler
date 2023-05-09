using _11.IdentityUygulama.Context;
using Microsoft.AspNetCore.Mvc;

namespace _11.IdentityUygulama.Controllers
{
	public class SilController : Controller
	{
		private readonly NorthwindContext _dbContext;
		public SilController(NorthwindContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
			return View();
		}
	}
}
