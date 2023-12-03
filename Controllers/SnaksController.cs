using Microsoft.AspNetCore.Mvc;

namespace Sushimi.Controllers
{
    public class SnaksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
