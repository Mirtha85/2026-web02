using LuxeStep.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<LuxeStepDbContext>(options =>
    options.UseSqlite(
        builder.Configuration["ConnectionStrings:LuxeStepDbContextConnection"]));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IShoeRepository, ShoeRepository>();

// ── Carrito de Compras ──────────────────────────────────────────────────────
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();
builder.Services.AddScoped<IShoppingCart, ShoppingCart>(sp => ShoppingCart.GetCart(sp));
// ────────────────────────────────────────────────────────────────────────────

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.UseSession();            // ← Debe ir ANTES de las rutas
app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();