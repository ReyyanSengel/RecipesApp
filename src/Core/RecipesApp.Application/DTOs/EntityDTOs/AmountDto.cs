using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.DTOs.EntityDTOs
{
    public class AmountDto : BaseDto
    {
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public List<IngredientDto> Ingredients { get; set; }
    }
}
