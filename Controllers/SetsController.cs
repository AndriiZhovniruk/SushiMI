using Microsoft.AspNetCore.Mvc;

namespace Sushimi.Controllers
{
    public class SetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
