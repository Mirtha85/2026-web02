namespace LuxeStep.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
        IEnumerable<Category> CategoriesOfTheWeek { get; }
        Category? GetCategoryById(int categoryId);
        IEnumerable<Category> SearchCategories(string searchQuery);
    }
}
