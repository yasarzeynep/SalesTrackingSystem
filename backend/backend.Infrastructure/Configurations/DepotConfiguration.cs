using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Infrastructure.Configurations;

internal sealed class DepotConfiguration : IEntityTypeConfiguration<Depot>
{
    public void Configure(EntityTypeBuilder<Depot> builder)
    {
        builder.Property(p => p.Name).HasColumnType("varchar(50)");
    }
}
