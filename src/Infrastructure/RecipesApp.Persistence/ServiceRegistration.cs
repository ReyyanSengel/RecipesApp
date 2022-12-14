using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecipesApp.Application.Interfaces.IRepository;
using RecipesApp.Application.Interfaces.IUnitOfWorks;
using RecipesApp.Persistence.Context;
using RecipesApp.Persistence.Repositories;
using RecipesApp.Persistence.UnitOfWorks;
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
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<RecipeAppDbContext>(
                options => options.UseSqlServer("name=ConnectionStrings:SqlConnection"));

            services.AddScoped<IAmountRepository, AmountRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDirectonRepository, DirectionRepository>();
            services.AddScoped<IIngredientRepository, IngredientRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            
        }
    }
}
