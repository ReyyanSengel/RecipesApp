using AutoMapper;
using RecipesApp.Application.DTOs.EntityDTOs;
using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.Mappig
{
    public class MapProfile : Profile
    {
        protected MapProfile()
        {
            CreateMap<Amount, AmountDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Direction, DirectionDto>().ReverseMap();
            CreateMap<Ingredient, IngredientDto>().ReverseMap();
            CreateMap<Recipe, RecipeDto>().ReverseMap();
        }
    }
}
