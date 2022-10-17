using RecipesApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Domain.Entities
{
    public class Amount : BaseEntity
    {
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
