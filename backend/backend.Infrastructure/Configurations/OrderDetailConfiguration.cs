using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Infrastructure.Configurations;

internal sealed class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {
        builder.HasOne(p => p.Product)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(p => p.Price).HasColumnType("money");
        builder.Property(p => p.Quantity).HasColumnType("decimal(7,2)");
    }
}
