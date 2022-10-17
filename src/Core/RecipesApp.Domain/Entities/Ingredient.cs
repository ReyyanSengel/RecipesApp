using RecipesApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Domain.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int AmountId { get; set; }
        public Amount Amount { get; set; }





    }
}
