using Microsoft.Extensions.DependencyInjection;
using RecipesApp.Application.Filters;
using RecipesApp.Application.Mappig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapProfile));
            services.AddScoped(typeof(NotFoundFilter<>));
        }
    }
}
