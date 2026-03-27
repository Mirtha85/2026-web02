using Microsoft.EntityFrameworkCore;

namespace LuxeStep.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly LuxeStepDbContext _context;

        public string? ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new();

        private ShoppingCart(LuxeStepDbContext context)
        {
            _context = context;
        }

        // Método estático que obtiene (o crea) el carrito usando la sesión del usuario
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            IHttpContextAccessor? httpContextAccessor =
                services.GetService<IHttpContextAccessor>();

            ISession session = httpContextAccessor?.HttpContext?.Session
                ?? throw new InvalidOperationException("No se pudo obtener la sesión.");

            LuxeStepDbContext context =
                services.GetRequiredService<LuxeStepDbContext>();

            // Recupera el CartId de la sesión o genera uno nuevo
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Shoe shoe)
        {
            var shoppingCartItem = _context.ShoppingCartItems
                .SingleOrDefault(s => s.Shoe.ShoeId == shoe.ShoeId
                                   && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    Shoe = shoe,
                    Amount = 1,
                    ShoppingCartId = ShoppingCartId
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _context.SaveChanges();
        }

        public int RemoveFromCart(Shoe shoe)
        {
            var shoppingCartItem = _context.ShoppingCartItems
                .SingleOrDefault(s => s.Shoe.ShoeId == shoe.ShoeId
                                   && s.ShoppingCartId == ShoppingCartId);

            int localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _context.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems = _context.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Shoe)
                .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _context.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId);

            _context.ShoppingCartItems.RemoveRange(cartItems);
            _context.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            return _context.ShoppingCartItems
                .Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Shoe.Price * c.Amount)
                .Sum();
        }
    }
}
