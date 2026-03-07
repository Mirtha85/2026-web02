namespace LuxeStep.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Deportivos",       Description = "Zapatillas para running y gym" },
                new Category { CategoryId = 2, CategoryName = "Casuales",         Description = "Cómodos para el día a día" },
                new Category { CategoryId = 3, CategoryName = "Formales",         Description = "Elegancia para cada ocasión" },
                new Category { CategoryId = 4, CategoryName = "Botines",          Description = "Estilo y altura en un solo modelo" },
                new Category { CategoryId = 5, CategoryName = "Sandalias",        Description = "Frescura y diseño para el verano" },
                new Category { CategoryId = 6, CategoryName = "Mocasines",        Description = "Sofisticación sin cordones" },
                new Category { CategoryId = 7, CategoryName = "Botas",            Description = "Protección y estilo en temporada fría" },
                new Category { CategoryId = 8, CategoryName = "Plataformas",      Description = "Altura con comodidad" },
                new Category { CategoryId = 9, CategoryName = "Oxford",           Description = "Clásicos de cuero para el profesional" },
                new Category { CategoryId = 10, CategoryName = "Edición Limitada", Description = "Modelos exclusivos de colección" },
            };

        public IEnumerable<Category> CategoriesOfTheWeek =>
            AllCategories.Where(c => c.IsCategoriesOfTheWeek);

        public Category? GetCategoryById(int categoryId) =>
            AllCategories.FirstOrDefault(c => c.CategoryId == categoryId);

        public IEnumerable<Category> SearchCategories(string searchQuery) =>
            throw new NotImplementedException();
    }
}
