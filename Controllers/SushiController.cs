using Microsoft.AspNetCore.Mvc;

namespace Sushimi.Controllers
{
	public class SushiController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
