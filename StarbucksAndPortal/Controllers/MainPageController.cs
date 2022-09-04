using Microsoft.AspNetCore.Mvc;

namespace StarbucksAndPortal.Controllers
{
    public class MainPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
