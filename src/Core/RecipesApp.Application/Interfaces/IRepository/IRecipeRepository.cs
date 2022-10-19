using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.Interfaces.IRepository
{
    public interface IRecipeRepository : IGenericRepository<Recipe>
    {
    }
}
