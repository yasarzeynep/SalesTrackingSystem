using backend.Domain.Entities;
using backend.Domain.Repositories;
using backend.Infrastructure.Context;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Infrastructure.Repositories;

internal sealed class ProductRepository : Repository<Product, ApplicationDbContext>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}