using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.DTOs.EntityDTOs
{
    public class RecipeDto : BaseDto
    {
        public string Title { get; set; }
        public List<CategoryDto> Categories { get; set; }
        public List<IngredientDto> Ingredients { get; set; }
        public int DirectionId { get; set; }
        public DirectionDto Direction { get; set; }
    }
}
