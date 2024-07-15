using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Infrastructure.Configurations;

internal sealed class RecipeDetailConfiguration : IEntityTypeConfiguration<RecipeDetail>
{
    public void Configure(EntityTypeBuilder<RecipeDetail> builder)
    {
        builder.Property(p => p.Quantity).HasColumnType("decimal(7,2)");
    }
}