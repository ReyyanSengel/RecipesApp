using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.DTOs.EntityDTOs
{
    public class CategoryDto : BaseDto
    {
        public string CategoryName { get; set; }
        public List<RecipeDto> Recipes { get; set; }
    }
}
