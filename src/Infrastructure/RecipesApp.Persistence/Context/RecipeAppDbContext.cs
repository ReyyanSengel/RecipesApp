using Microsoft.EntityFrameworkCore;
using RecipesApp.Domain.Entities;
using RecipesApp.Domain.EntityTypeBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Persistence.Context
{
    public class RecipeAppDbContext : DbContext
    {
        public RecipeAppDbContext(DbContextOptions<RecipeAppDbContext> options) : base(options)
        {
        }

        public DbSet<Amount> Amounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new AmountTypeBuilder())
                .ApplyConfiguration(new CategoryTypeBuilder())
                .ApplyConfiguration(new DirectionTypeBuilder())
                .ApplyConfiguration(new IngredientTypeBuilder())
                .ApplyConfiguration(new RecipeTypeBuilder());

            base.OnModelCreating(modelBuilder);
        }
    }


}
