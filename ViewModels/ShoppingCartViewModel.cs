using LuxeStep.Models;

namespace LuxeStep.ViewModels
{
    public class ShoppingCartViewModel
    {
        public IEnumerable<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();
        public decimal ShoppingCartTotal { get; set; }
    }
}
