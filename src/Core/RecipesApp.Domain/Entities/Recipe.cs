using RecipesApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Domain.Entities
{
    public class Recipe : BaseEntity
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public  Category Category { get; set; }
        public  ICollection<Ingredient> Ingredients { get; set; }
        public int DirectionId { get; set; }
        public  Direction Direction { get; set; }
    }
}
