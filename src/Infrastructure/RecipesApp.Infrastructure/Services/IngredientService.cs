using RecipesApp.Application.Interfaces.IRepository;
using RecipesApp.Application.Interfaces.IService;
using RecipesApp.Application.Interfaces.IUnitOfWorks;
using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Infrastructure.Services
{
    public class IngredientService : GenericService<Ingredient>, IIngredientService
    {
        public IngredientService(IGenericRepository<Ingredient> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
