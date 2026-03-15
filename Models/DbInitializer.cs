namespace LuxeStep.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            LuxeStepDbContext context = applicationBuilder.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<LuxeStepDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category { CategoryName = "Deportivos", Description = "Zapatillas para running y gym" },
                    new Category { CategoryName = "Casuales", Description = "Cómodos para el día a día" },
                    new Category { CategoryName = "Formales", Description = "Elegancia para cada ocasión" },
                    new Category { CategoryName = "Botines", Description = "Estilo y altura en un solo modelo" },
                    new Category { CategoryName = "Sandalias", Description = "Frescura y diseño para el verano" },
                    new Category { CategoryName = "Mocasines", Description = "Sofisticación sin cordones" },
                    new Category { CategoryName = "Botas", Description = "Protección y estilo en temporada fría" },
                    new Category { CategoryName = "Plataformas", Description = "Altura con comodidad" },
                    new Category { CategoryName = "Oxford", Description = "Clásicos de cuero para el profesional" },
                    new Category { CategoryName = "Edición Limitada", Description = "Modelos exclusivos de colección" }
                );
                context.SaveChanges();
            }

            if (!context.Shoes.Any())
            {
                var deportivos   = context.Categories.First(c => c.CategoryName == "Deportivos");
                var casuales     = context.Categories.First(c => c.CategoryName == "Casuales");
                var formales     = context.Categories.First(c => c.CategoryName == "Formales");
                var botines      = context.Categories.First(c => c.CategoryName == "Botines");
                var sandalias    = context.Categories.First(c => c.CategoryName == "Sandalias");
                var mocasines    = context.Categories.First(c => c.CategoryName == "Mocasines");
                var botas        = context.Categories.First(c => c.CategoryName == "Botas");
                var plataformas  = context.Categories.First(c => c.CategoryName == "Plataformas");
                var oxford       = context.Categories.First(c => c.CategoryName == "Oxford");
                var edicion      = context.Categories.First(c => c.CategoryName == "Edición Limitada");

                context.Shoes.AddRange(
                    new Shoe { Name = "Nike Air Max 270", Brand = "Nike", Price = 149.99M, ShortDescription = "Comodidad extrema con amortiguación Air", LongDescription = "La suela Air más grande de Nike, ideal para uso diario o deporte ligero.", Gender = "Unisex", Category = deportivos, ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600&q=80", InStock = true, IsShoeOfTheWeek = true },
                    new Shoe { Name = "Adidas Stan Smith", Brand = "Adidas", Price = 99.99M, ShortDescription = "Icónico tenis blanco atemporal", LongDescription = "El clásico de Adidas que nunca pasa de moda.", Gender = "Unisex", Category = casuales, ImageUrl = "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600&q=80", InStock = true, IsShoeOfTheWeek = false },
                    new Shoe { Name = "Oxford Clásico Cuero", Brand = "LuxeStep", Price = 189.99M, ShortDescription = "Elegancia pura en cuero genuino", LongDescription = "Oxford de cuero italiano con suela de cuero, perfecto para ambientes formales.", Gender = "Hombre", Category = oxford, ImageUrl = "https://images.unsplash.com/photo-1614252235316-8c857d38b5f4?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1614252235316-8c857d38b5f4?w=600&q=80", InStock = true, IsShoeOfTheWeek = false },
                    new Shoe { Name = "Botín Chelsea Negro", Brand = "LuxeStep", Price = 219.99M, ShortDescription = "El botín más versátil del guardarropa", LongDescription = "Cuero full-grain, elásticos laterales y suela de goma duradera.", Gender = "Hombre", Category = botines, ImageUrl = "https://images.unsplash.com/photo-1638247025967-b4e38f787b76?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1638247025967-b4e38f787b76?w=600&q=80", InStock = true, IsShoeOfTheWeek = true },
                    new Shoe { Name = "Sandalia Tiras Doradas", Brand = "LuxeStep", Price = 89.99M, ShortDescription = "Diseño ligero y elegante para verano", LongDescription = "Sandalias con tiras cruzadas en material sintético dorado.", Gender = "Mujer", Category = sandalias, ImageUrl = "https://images.unsplash.com/photo-1543163521-1bf539c55dd2?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1543163521-1bf539c55dd2?w=600&q=80", InStock = true, IsShoeOfTheWeek = false },
                    new Shoe { Name = "Mocasín Penny Loafer", Brand = "LuxeStep", Price = 159.99M, ShortDescription = "Confort y sofisticación sin esfuerzo", LongDescription = "Mocasín de cuero con detalle penny en el frente.", Gender = "Hombre", Category = mocasines, ImageUrl = "https://images.unsplash.com/photo-1603808033192-082d6919d3e1?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1603808033192-082d6919d3e1?w=600&q=80", InStock = true, IsShoeOfTheWeek = false },
                    new Shoe { Name = "Bota Militar Táctica", Brand = "LuxeStep", Price = 249.99M, ShortDescription = "Resistencia y estilo en cada paso", LongDescription = "Bota de cuero con cierre lateral, suela antideslizante y puntera reforzada.", Gender = "Unisex", Category = botas, ImageUrl = "https://images.unsplash.com/photo-1608256246200-53e635b5b65f?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1608256246200-53e635b5b65f?w=600&q=80", InStock = true, IsShoeOfTheWeek = true },
                    new Shoe { Name = "Plataforma Urbana", Brand = "LuxeStep", Price = 129.99M, ShortDescription = "Altura extra con look urbano moderno", LongDescription = "Zapatilla con plataforma de 5cm, parte superior en lona y suela de goma.", Gender = "Mujer", Category = plataformas, ImageUrl = "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1595950653106-6c9ebd614d3a?w=600&q=80", InStock = true, IsShoeOfTheWeek = false },
                    new Shoe { Name = "Tacón Stiletto Rojo", Brand = "LuxeStep", Price = 174.99M, ShortDescription = "Audaz, poderosa y elegante", LongDescription = "Tacón de aguja 10cm en charol rojo, forro interior acolchado.", Gender = "Mujer", Category = formales, ImageUrl = "https://images.unsplash.com/photo-1515347619252-60a4bf4fff4f?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1515347619252-60a4bf4fff4f?w=600&q=80", InStock = true, IsShoeOfTheWeek = false },
                    new Shoe { Name = "Edición Oro Negro", Brand = "LuxeStep", Price = 399.99M, ShortDescription = "Colección exclusiva de lujo", LongDescription = "Zapato artesanal con detalles en hilo dorado, cuero de becerro italiano.", Gender = "Unisex", Category = edicion, ImageUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600&q=80", ImageThumbnailUrl = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?w=600&q=80", InStock = true, IsShoeOfTheWeek = true }
                );
                context.SaveChanges();
            }
        }
    }
}