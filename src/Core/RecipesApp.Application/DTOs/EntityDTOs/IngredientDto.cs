using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.DTOs.EntityDTOs
{
    public class IngredientDto : BaseDto
    {
        public string Name { get; set; }
        public int RecipeId { get; set; }
        public RecipeDto Recipe { get; set; }
        public int AmountId { get; set; }
        public AmountDto Amount { get; set; }
    }
}
