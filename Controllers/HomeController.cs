using Microsoft.AspNetCore.Mvc;
using LuxeStep.Models;
using LuxeStep.ViewModels;

namespace LuxeStep.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShoeRepository _shoeRepository;

        public HomeController(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                ShoesOfTheWeek = _shoeRepository.ShoesOfTheWeek,
                AllShoes = _shoeRepository.AllShoes
            };
            return View(viewModel);
        }
    }
}