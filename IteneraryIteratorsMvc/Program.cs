using IteneraryIteratorsMvc.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IteneraryIteratorsMvc
{
	public class Program
	{
		public static void Main(string[] args)
		{
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<DataService>();

            // H�mta connection-str�ngen fr�n AppSettings.json
            var connString = builder.Configuration.GetConnectionString("DefaultConnection");
            // Registrera Context-klassen f�r dependency injection
            builder.Services.AddDbContext<ApplicationContext>(o => o.UseSqlServer(connString));
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationContext>()
            .AddDefaultTokenProviders();
            // 2. Specificera att cookies ska anv�ndas och URL till inloggnings-sidan
            builder.Services.ConfigureApplicationCookie(
            o => o.LoginPath = "/login");
            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            if (!app.Environment.IsDevelopment())
            {
                app.UseStatusCodePagesWithRedirects("/error/http/{0}");
				app.UseExceptionHandler("/error/exception");
            }

			app.UseRouting();
            app.UseAuthorization(); // 3. Beh�righet
            app.UseEndpoints(o => o.MapControllers());

            app.Run();
        }
	}
}