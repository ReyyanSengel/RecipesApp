using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.DTOs
{
    public class RecipeUpdateDto
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int IngredientId { get; set; }
        public int AmountId { get; set; }
        public string Step { get; set; }
    }
}
