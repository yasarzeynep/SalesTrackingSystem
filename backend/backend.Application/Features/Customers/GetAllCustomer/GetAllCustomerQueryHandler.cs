using backend.Domain.Entities;
using backend.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace backend.Application.Features.Customers.GetAllCustomer;

internal sealed class GetAllCustomerQueryHandler(
    ICustomerRepository customerRepository) : IRequestHandler<GetAllCustomerQuery, Result<List<Customer>>>
{
    public async Task<Result<List<Customer>>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
    {
        List<Customer> customers = await customerRepository.GetAll().OrderBy(p => p.Name).ToListAsync(cancellationToken);

        return customers;
    }
}
