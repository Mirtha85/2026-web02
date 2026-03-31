using Microsoft.EntityFrameworkCore;

namespace LuxeStep.Models
{
    public class LuxeStepDbContext : DbContext
    {
        public LuxeStepDbContext(DbContextOptions<LuxeStepDbContext> options)
            : base(options)
        {
        }

        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<MensajeContacto> MensajesContacto { get; set; }
    }
}