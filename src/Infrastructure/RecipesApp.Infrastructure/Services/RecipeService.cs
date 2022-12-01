using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Application.DTOs.EntityDTOs;
using RecipesApp.Application.Interfaces.IRepository;
using RecipesApp.Application.Interfaces.IService;
using RecipesApp.Application.Interfaces.IUnitOfWorks;
using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Infrastructure.Services
{
    public class RecipeService : GenericService<Recipe>, IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IUnitOfWork _unitOfWork;
        public RecipeService(IGenericRepository<Recipe> repository, IUnitOfWork unitOfWork, IRecipeRepository recipeRepository) : base(repository, unitOfWork)
        {
            _recipeRepository = recipeRepository;
            _unitOfWork = unitOfWork;
        }

        //public async Task<Recipe> AddRecipe(RecipeDto recipeDto)
        //{
            

        //}

        public async Task<List<RecipeDto>> GetRecipeAll()
        {

            var result = await _recipeRepository.GetAllAsync()
                 .Include(x => x.Category)
                 .Include(x => x.Ingredients).ThenInclude(x => x.Amount)
                 .Include(x => x.Direction)
                 .ToListAsync();

            var query = (from recipe in result
                         select new RecipeDto()
                         {
                             Title = recipe.Title,
                             RecipeId = recipe.Id,
                             CategoryId = recipe.CategoryId,
                             Direction = new DirectionDto()
                             {
                                 Step = recipe.Direction.Step,
                                 DirectionId = recipe.Direction.Id,
                             },
                             Ingredients = (from ingredient in recipe.Ingredients
                                            select new IngredientDto()
                                            {
                                                Name = ingredient.Name,
                                                IngredientId=ingredient.Id,
                                                Amount = new AmountDto()
                                                {
                                                    AmountId = ingredient.Amount.Id,
                                                    Quantity = ingredient.Amount.Quantity,
                                                    Unit = ingredient.Amount.Unit
                                                }
                                            }).ToList()

                         }).ToList();
            return query;

        }

        public async Task<RecipeDto> GetRecipeById(int id)
        {
            var result = await _recipeRepository.GetAllAsync()
                .Where(x => x.Id == id)
                .Include(x => x.Category)
                .Include(x => x.Ingredients).ThenInclude(x => x.Amount)
                .Include(x => x.Direction)
                .FirstOrDefaultAsync();

            RecipeDto recipeDto = new RecipeDto();
            recipeDto.Title = result.Title;
            recipeDto.RecipeId = result.Id;
            recipeDto.CategoryId = result.CategoryId;
            recipeDto.Ingredients = (from ingredient in result.Ingredients
                                     select new IngredientDto()
                                     {
                                         Name = ingredient.Name,
                                         IngredientId=ingredient.Id,
                                         Amount = new AmountDto()
                                         {
                                             AmountId= ingredient.Amount.Id,
                                             Quantity = ingredient.Amount.Quantity,
                                             Unit = ingredient.Amount.Unit
                                         }
                                     }).ToList();
            recipeDto.Direction = new DirectionDto()
            {
                DirectionId=result.Id,
                Step = result.Direction.Step
            };

            return recipeDto;
        }

        //public async Task<Recipe> UpdateRecipeAsync(RecipeDto recipeDto)
        //{
        //   var newRecipe=await _recipeRepository.


        //    newRecipe.Title=recipeDto.Title;
            
        //    newRecipe.Categories= (from category in recipeDto.Categories
        //                           select new Category()
        //                           {
        //                               CategoryName= category.CategoryName,
        //                           }).ToList();
        //    newRecipe.Ingredients = (from ingredient in recipeDto.Ingredients
        //                             select new Ingredient()
        //                             {
        //                                 Name = ingredient.Name,
        //                                 Amount = new Amount()
        //                                 {
        //                                     Quantity = ingredient.Amount.Quantity,
        //                                     Unit = ingredient.Amount.Unit
        //                                 }
        //                             }).ToList();
        //    newRecipe.Direction = new Direction()
        //    {
        //        Step = recipeDto.Direction.Step,
        //    };

        //     _recipeRepository.Update(newRecipe);
        //    _unitOfWork.Commit();
        //    return newRecipe;
        //}
    }
}






