using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Domain.EntityTypeBuilder
{
    public class CategoryTypeBuilder : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName)
                 .IsRequired()
                 .HasColumnType("nvarchar")
                 .HasMaxLength(256);
            //builder.HasMany(x => x.Recipes).WithMany(x => x.Categories);
        }
    }
}
