using backend.Domain.Entities;
using backend.Domain.Repositories;
using backend.Infrastructure.Context;
using GenericRepository;

namespace backend.Infrastructure.Repositories;
internal sealed class ProductionRepositor : Repository<Production, ApplicationDbContext>, IProductionRepository
{
    public ProductionRepositor(ApplicationDbContext context) : base(context)
    {
    }
}
