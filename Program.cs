using LuxeStep.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<LuxeStepDbContext>(options =>
    options.UseSqlite(
        builder.Configuration["ConnectionStrings:LuxeStepDbContextConnection"]));

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IShoeRepository, ShoeRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();