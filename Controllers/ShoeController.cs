using Microsoft.AspNetCore.Mvc;
using LuxeStep.Models;
using LuxeStep.ViewModels;

namespace LuxeStep.Controllers
{
    public class ShoeController : Controller
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ShoeController(IShoeRepository shoeRepository, ICategoryRepository categoryRepository)
        {
            _shoeRepository = shoeRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            ShoeListViewModel shoeListViewModel = new ShoeListViewModel(_shoeRepository.AllShoes, "Todos los Zapatos");
            return View(shoeListViewModel);
        }

        public IActionResult Detail(int id)
        {
            Shoe? shoe = _shoeRepository.GetShoeById(id);
            if (shoe == null)
                return NotFound();
            return View(shoe);
        }
    }
}