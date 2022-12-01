using RecipesApp.Application.DTOs.EntityDTOs;
using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.Interfaces.IService
{
    public interface IRecipeService : IGenericService<Recipe>
    {
        Task<List<RecipeDto>> GetRecipeAll();
        Task<RecipeDto> GetRecipeById(int id);
        //Task<Recipe> AddRecipe(RecipeDto recipeDto);
        //Task<Recipe> UpdateRecipeAsync(int id ,RecipeDto recipeDto);

    }
}
