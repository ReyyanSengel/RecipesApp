using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RecipesApp.Domain.Entities;
using RecipesApp.Domain.EntityTypeBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesApp.Domain.Entities.Identity;

namespace RecipesApp.Persistence.Context
{
    public class RecipeAppDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public RecipeAppDbContext(DbContextOptions<RecipeAppDbContext> options) : base(options)
        {
        }

        public DbSet<Amount> Amounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new AmountTypeBuilder())
                .ApplyConfiguration(new CategoryTypeBuilder())
                .ApplyConfiguration(new DirectionTypeBuilder())
                .ApplyConfiguration(new IngredientTypeBuilder())
                .ApplyConfiguration(new RecipeTypeBuilder())
                .ApplyConfiguration(new UserRefreshTokenTypeBuilder());

            base.OnModelCreating(modelBuilder);
        }

    }




}
