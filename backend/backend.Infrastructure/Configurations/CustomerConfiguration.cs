using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Infrastructure.Configurations;

//dısarıya paylasmıyacagımız icin internal kalabilir

internal sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {

        //ornek bir tane; max on tane olması 
        builder.Property(p => p.TaxNumber).HasColumnType("varchar(11)");
    }
}
