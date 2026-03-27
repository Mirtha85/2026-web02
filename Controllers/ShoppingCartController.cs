using Microsoft.AspNetCore.Mvc;
using LuxeStep.Models;
using LuxeStep.ViewModels;

namespace LuxeStep.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(IShoeRepository shoeRepository, IShoppingCart shoppingCart)
        {
            _shoeRepository = shoeRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var viewModel = new ShoppingCartViewModel
            {
                ShoppingCartItems = items,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(viewModel);
        }

        public IActionResult AddToShoppingCart(int shoeId)
        {
            Shoe? shoe = _shoeRepository.GetShoeById(shoeId);

            if (shoe != null)
                _shoppingCart.AddToCart(shoe);

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int shoeId)
        {
            Shoe? shoe = _shoeRepository.GetShoeById(shoeId);

            if (shoe != null)
                _shoppingCart.RemoveFromCart(shoe);

            return RedirectToAction("Index");
        }
    }
}
