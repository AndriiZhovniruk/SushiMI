using Microsoft.AspNetCore.Mvc;

namespace Sushimi.Controllers
{
    public class HotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
