namespace LuxeStep.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly LuxeStepDbContext _context;

        public CategoryRepository(LuxeStepDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> AllCategories =>
            _context.Categories.OrderBy(c => c.CategoryName);

        public IEnumerable<Category> CategoriesOfTheWeek =>
            _context.Categories.Where(c => c.IsCategoriesOfTheWeek);

        public Category? GetCategoryById(int categoryId) =>
            _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

        public IEnumerable<Category> SearchCategories(string searchQuery) =>
            _context.Categories.Where(c => c.CategoryName.Contains(searchQuery));
    }
}