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


// dısa paylasmıyacagımız için internal kalabilir
internal sealed class CustomerRepository : Repository<Customer, ApplicationDbContext>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
    }
}
