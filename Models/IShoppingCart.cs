namespace LuxeStep.Models
{
    public interface IShoppingCart
    {
        void AddToCart(Shoe shoe);
        int RemoveFromCart(Shoe shoe);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
