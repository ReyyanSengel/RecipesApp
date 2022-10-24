using RecipesApp.Application.Interfaces.IRepository;
using RecipesApp.Domain.Entities;
using RecipesApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(RecipeAppDbContext context) : base(context)
        {
        }
    }
}
