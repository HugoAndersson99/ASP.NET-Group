using ASP.Net_GruppUPG.Objects;
using ASP.Net_GruppUPG.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ASP.Net_GruppUPG
{
    public class Program
    {
        //TESTA OM GITHUB FUNGERAR
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllers().AddJsonOptions(option =>
                option.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            //builder.Services.AddControllers();
            builder.Services.AddTransient<MediaUserService>();
            builder.Services.AddTransient<MovieService>();
            builder.Services.AddTransient<SerieService>();

            string connectionString = builder.Configuration.GetConnectionString("HugoSqlConnectionString");

            builder.Services.AddDbContext<DatabaseContext>(option => option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.MapControllers();

            app.Run();
        }
    }
}
