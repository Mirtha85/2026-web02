namespace LuxeStep.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Category>? Categories { get; set; }
        public bool IsCategoriesOfTheWeek { get; set; }
    }
}
