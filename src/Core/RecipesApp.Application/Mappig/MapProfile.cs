using AutoMapper;
using RecipesApp.Application.DTOs.EntityDTOs;
using RecipesApp.Application.DTOs.TokenDtos;
using RecipesApp.Domain.Entities;
using RecipesApp.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecipesApp.Application.Mappig
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Amount, AmountDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Direction, DirectionDto>().ReverseMap();
            CreateMap<Ingredient, IngredientDto>().ReverseMap();
            CreateMap<Recipe, RecipeDto>().ReverseMap();
            CreateMap<AddRecipeDto, Recipe>().ReverseMap();
            CreateMap<AppUser, AppUserDto>().ReverseMap();
        }
    }
}
            
           

           
            


