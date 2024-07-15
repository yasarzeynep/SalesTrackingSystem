using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Enums;

namespace backend.Infrastructure.Configurations;

internal sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
      
        builder.Property(p => p.Status)
            .HasConversion(status => status.Value, value => OrderStatusEnum.FromValue(value));
    }
}
