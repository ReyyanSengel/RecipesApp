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
    public class AmountTypeBuilder : IEntityTypeConfiguration<Amount>
    {
        public void Configure(EntityTypeBuilder<Amount> builder)
        {
            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasColumnType("int")
                .HasMaxLength(10);
            builder.Property(x => x.Unit)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(50);
            //builder.HasMany(x => x.Ingredients).WithOne(x => x.Amount).HasForeignKey(x => x.AmountId);
        }
    }
}
