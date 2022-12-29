using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Razerwebpages.Data;
using Razerwebpages.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddDbContext<RazerwebpagesContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("RazerwebpagesContext") ?? throw new InvalidOperationException("Connection string 'RazerwebpagesContext' not found.")));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
       
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;

            SeedData.Initialize(services);
        }

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }


        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();



    }
        

}