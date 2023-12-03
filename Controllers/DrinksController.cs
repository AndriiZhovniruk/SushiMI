using Microsoft.AspNetCore.Mvc;

namespace Sushimi.Controllers
{
    public class DrinksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
