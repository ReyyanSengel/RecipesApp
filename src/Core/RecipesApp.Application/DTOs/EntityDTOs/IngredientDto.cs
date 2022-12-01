﻿using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.DTOs.EntityDTOs
{
    public class IngredientDto 
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public AmountDto Amount { get; set; }
    }





}
