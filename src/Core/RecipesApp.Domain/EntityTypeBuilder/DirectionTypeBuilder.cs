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
    public class DirectionTypeBuilder : IEntityTypeConfiguration<Direction>
    {
        public void Configure(EntityTypeBuilder<Direction> builder)
        {
            builder.Property(x => x.Step)
                 .IsRequired()
                 .HasColumnType("nvarchar")
                 .HasMaxLength(1050);

        }
    }
}

