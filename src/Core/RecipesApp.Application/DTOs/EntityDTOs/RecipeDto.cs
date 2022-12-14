using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.DTOs.EntityDTOs
{
    public class RecipeDto
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public List<IngredientDto> Ingredients { get; set; }
        public DirectionDto Direction { get; set; }
    }

}
   

