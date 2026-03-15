using Microsoft.EntityFrameworkCore;

namespace LuxeStep.Models
{
    public class ShoeRepository : IShoeRepository
    {
        private readonly LuxeStepDbContext _context;

        public ShoeRepository(LuxeStepDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Shoe> AllShoes =>
            _context.Shoes.Include(s => s.Category).OrderBy(s => s.Name);

        public IEnumerable<Shoe> ShoesOfTheWeek =>
            _context.Shoes.Include(s => s.Category).Where(s => s.IsShoeOfTheWeek);

        public Shoe? GetShoeById(int shoeId) =>
            _context.Shoes.Include(s => s.Category)
                          .FirstOrDefault(s => s.ShoeId == shoeId);

        public IEnumerable<Shoe> SearchShoes(string searchQuery) =>
            _context.Shoes.Include(s => s.Category)
                          .Where(s => s.Name.Contains(searchQuery));
    }
}