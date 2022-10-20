using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipesApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<RecipeAppDbContext>(
                options => options.UseSqlServer("name=ConnectionStrings:SqlConnection"));

            //var appSettings = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsettings.json")
            //     .Build();


            //services.AddDbContext<RecipeAppDbContext>(x =>
            //{
            //    x.UseSqlServer(appSettings.GetConnectionString("SqlConnection"), option =>
            //    {
            //        option.MigrationsAssembly(Assembly.GetAssembly(typeof(RecipeAppDbContext)).GetName().Name);
            //    });
            //});
        }
    }
}
