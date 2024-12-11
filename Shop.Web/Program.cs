using Microsoft.EntityFrameworkCore;
using Shop.data.Context;
using Shop.data.Daos;
using Shop.data.Interfaces;

namespace Shop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ICategoriesRepository, CategoriesDao>();
            builder.Services.AddScoped<ICustomersRepository, CustomersDao>();
            builder.Services.AddScoped<IEmployeesRepository, EmployeesDao>();

            builder.Services.AddDbContext<ShopDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ShopDb")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
