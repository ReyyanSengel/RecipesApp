using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.DTOs.EntityDTOs
{
    public class AddRecipeDto
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public CategoryDto Category { get; set; }
        public IngredientDto Ingredient { get; set; }
        public DirectionDto Direction { get; set; }
       
    }
}
