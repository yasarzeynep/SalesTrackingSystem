using backend.Domain.Entities;
using backend.Domain.Repositories;
using backend.Infrastructure.Context;
using GenericRepository;

namespace backend.Infrastructure.Repositories;
internal sealed class InvoiceRepository : Repository<Invoice, ApplicationDbContext>, IInvoiceRepository
{
    public InvoiceRepository(ApplicationDbContext context) : base(context)
    {
    }
}
