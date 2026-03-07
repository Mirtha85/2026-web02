using Microsoft.AspNetCore.Mvc;

namespace LuxeStep.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List", "Shoe");
        }
    }
}