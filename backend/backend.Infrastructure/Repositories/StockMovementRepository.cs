using backend.Domain.Entities;
using backend.Domain.Repositories;
using backend.Infrastructure.Context;
using GenericRepository;

namespace backend.Infrastructure.Repositories;
internal sealed class StockMovementRepository : Repository<StockMovement, ApplicationDbContext>, IStockMovementRepository
{
    public StockMovementRepository(ApplicationDbContext context) : base(context)
    {
    }
}
