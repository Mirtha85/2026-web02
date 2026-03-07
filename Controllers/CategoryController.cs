using Microsoft.AspNetCore.Mvc;
using LuxeStep.Models;
using LuxeStep.ViewModels;

namespace LuxeStep.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var categories = _categoryRepository.AllCategories;
            var categoryListViewModel = new CategoryListViewModel(categories, "Todas las Categorías");
            return View(categoryListViewModel);
        }
    }
}
