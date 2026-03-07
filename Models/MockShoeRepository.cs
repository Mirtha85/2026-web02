namespace LuxeStep.Models
{
    public class MockShoeRepository : IShoeRepository
    {
        private readonly List<Shoe> _shoes;

        public MockShoeRepository(ICategoryRepository categoryRepository)
        {
            Category GetCat(int id) =>
                categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryId == id)
                ?? new Category { CategoryId = id, CategoryName = "General" };

            _shoes = new List<Shoe>
            {
                new Shoe { ShoeId = 1,  Name = "Nike Air Max 270",        Brand = "Nike",        Price = 149.99M, ShortDescription = "Comodidad extrema con amortiguación Air",      LongDescription = "La suela Air más grande de Nike, ideal para uso diario o deporte ligero.",          Gender = "Unisex",  Category = GetCat(1),  InStock = true, IsShoeOfTheWeek = true,
                    ImageUrl          = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/skwgyqrbfzhu6uyeh0gg/air-max-270-mens-shoes-KkLcGR.png",
                    ImageThumbnailUrl = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/skwgyqrbfzhu6uyeh0gg/air-max-270-mens-shoes-KkLcGR.png" },

                new Shoe { ShoeId = 2,  Name = "Adidas Stan Smith",        Brand = "Adidas",      Price = 99.99M,  ShortDescription = "Icónico tenis blanco atemporal",                LongDescription = "El clásico de Adidas que nunca pasa de moda. Cuero liso y suela caucho.",             Gender = "Unisex",  Category = GetCat(2),  InStock = true, IsShoeOfTheWeek = false,
                    ImageUrl          = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/7ed0855435194229a525aad6009a0497_9366/Stan_Smith_Shoes_White_FX5502_01_standard.jpg",
                    ImageThumbnailUrl = "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/7ed0855435194229a525aad6009a0497_9366/Stan_Smith_Shoes_White_FX5502_01_standard.jpg" },

                new Shoe { ShoeId = 3,  Name = "Oxford Clásico Cuero",     Brand = "LuxeStep",    Price = 189.99M, ShortDescription = "Elegancia pura en cuero genuino",               LongDescription = "Oxford de cuero italiano con suela de cuero, perfecto para ambientes formales.",       Gender = "Hombre",  Category = GetCat(9),  InStock = true, IsShoeOfTheWeek = false,
                    ImageUrl          = "https://images.unsplash.com/photo-1614252235316-8c857d38b5f4?w=600&q=80",
                    ImageThumbnailUrl = "https://images.unsplash.com/photo-1614252235316-8c857d38b5f4?w=600&q=80" },

                new Shoe { ShoeId = 4,  Name = "Botín Chelsea Negro",      Brand = "LuxeStep",    Price = 219.99M, ShortDescription = "El botín más versátil del guardarropa",         LongDescription = "Cuero full-grain, elásticos laterales y suela de goma duradera.",                     Gender = "Hombre",  Category = GetCat(4),  InStock = true, IsShoeOfTheWeek = true,
                    ImageUrl          = "https://images.unsplash.com/photo-1638247025967-b4e38f787b76?w=600&q=80",
                    ImageThumbnailUrl = "https://images.unsplash.com/photo-1638247025967-b4e38f787b76?w=600&q=80" },

                new Shoe { ShoeId = 5,  Name = "Sandalia Tiras Doradas",   Brand = "LuxeStep",    Price = 89.99M,  ShortDescription = "Diseño ligero y elegante para verano",          LongDescription = "Sandalias con tiras cruzadas en material sintético dorado, suela acolchada.",          Gender = "Mujer",   Category = GetCat(5),  InStock = true, IsShoeOfTheWeek = false,
                    ImageUrl          = "https://images.unsplash.com/photo-1543163521-1bf539c55dd2?w=600&q=80",
                    ImageThumbnailUrl = "https://images.unsplash.com/photo-1543163521-1bf539c55dd2?w=600&q=80" },

                new Shoe { ShoeId = 6,  Name = "Mocasín Penny Loafer",     Brand = "LuxeStep",    Price = 159.99M, ShortDescription = "Confort y sofisticación sin esfuerzo",          LongDescription = "Mocasín de cuero con detalle penny en el frente. Suela de cuero cosida a mano.",     Gender = "Hombre",  Category = GetCat(6),  InStock = true, IsShoeOfTheWeek = false,
                    ImageUrl          = "https://images.unsplash.com/photo-1603808033192-082d6919d3e1?w=600&q=80",
                    ImageThumbnailUrl = "https://images.unsplash.com/photo-1603808033192-082d6919d3e1?w=600&q=80" },

                new Shoe { ShoeId = 7,  Name = "Bota Militar Táctica",     Brand = "LuxeStep",    Price = 249.99M, ShortDescription = "Resistencia y estilo en cada paso",             LongDescription = "Bota de cuero con cierre lateral, suela antideslizante y puntera reforzada.",          Gender = "Unisex",  Category = GetCat(7),  InStock = true, IsShoeOfTheWeek = true,
                    ImageUrl          = "https://images.unsplash.com/photo-1608256246200-53e635b5b65f?w=600&q=80",
                    ImageThumbnailUrl = "https://images.unsplash.com/photo-1608256246200-53e635b5b65f?w=600&q=80" },

                new Shoe { ShoeId = 8,  Name = "Plataforma Urbana",        Brand = "LuxeStep",    Price = 129.99M, ShortDescription = "Altura extra con look urbano moderno",          LongDescription = "Zapatilla con plataforma de 5cm, parte superior en lona y suela de goma.",            Gender = "Mujer",   Category = GetCat(8),  InStock = true, IsShoeOfTheWeek = false,
                    ImageUrl          = "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600&q=80",
                    ImageThumbnailUrl = "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600&q=80" },

                new Shoe { ShoeId = 9,  Name = "Puma Suede Classic",       Brand = "Puma",        Price = 109.99M, ShortDescription = "Gamuza suave, estilo retro legendario",         LongDescription = "El Suede de Puma, un ícono de la cultura urbana desde 1968.",                         Gender = "Unisex",  Category = GetCat(2),  InStock = true, IsShoeOfTheWeek = false,
                    ImageUrl          = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_600,h_600/global/374915/01/sv01/fnd/PNA/fmt/png/PUMA-Suede-Classic-XXI-Sneakers",
                    ImageThumbnailUrl = "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa,w_600,h_600/global/374915/01/sv01/fnd/PNA/fmt/png/PUMA-Suede-Classic-XXI-Sneakers" },

                new Shoe { ShoeId = 10, Name = "Tacón Stiletto Rojo",      Brand = "LuxeStep",    Price = 174.99M, ShortDescription = "Audaz, poderosa y elegante",                    LongDescription = "Tacón de aguja 10cm en charol rojo, forro interior acolchado.",                        Gender = "Mujer",   Category = GetCat(3),  InStock = true, IsShoeOfTheWeek = false,
                    ImageUrl          = "https://images.unsplash.com/photo-1515347619252-60a4bf4fff4f?w=600&q=80",
                    ImageThumbnailUrl = "https://images.unsplash.com/photo-1515347619252-60a4bf4fff4f?w=600&q=80" },

                new Shoe { ShoeId = 11, Name = "New Balance 574",          Brand = "New Balance", Price = 119.99M, ShortDescription = "Clásico deportivo de máximo confort",           LongDescription = "Zapatilla retro con suela ENCAP, parte superior en gamuza y malla.",                    Gender = "Unisex",  Category = GetCat(1),  InStock = true, IsShoeOfTheWeek = false,
                    ImageUrl          = "https://nb.scene7.com/is/image/NB/ml574evg_nb_02_i?$pdpflexf2$&qlt=80&fmt=webp&wid=880&hei=660",
                    ImageThumbnailUrl = "https://nb.scene7.com/is/image/NB/ml574evg_nb_02_i?$pdpflexf2$&qlt=80&fmt=webp&wid=880&hei=660" },

                new Shoe { ShoeId = 12, Name = "Edición Oro Negro",        Brand = "LuxeStep",    Price = 399.99M, ShortDescription = "Colección exclusiva de lujo",                   LongDescription = "Zapato artesanal con detalles en hilo dorado, cuero de becerro italiano, edición 50u.", Gender = "Unisex",  Category = GetCat(10), InStock = true, IsShoeOfTheWeek = true,
                    ImageUrl          = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600&q=80",
                    ImageThumbnailUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600&q=80" },
            };
        }

        public IEnumerable<Shoe> AllShoes => _shoes;

        public IEnumerable<Shoe> ShoesOfTheWeek =>
            _shoes.Where(s => s.IsShoeOfTheWeek);

        public Shoe? GetShoeById(int shoeId) =>
            _shoes.FirstOrDefault(s => s.ShoeId == shoeId);

        public IEnumerable<Shoe> SearchShoes(string searchQuery) =>
            throw new NotImplementedException();
    }
}
