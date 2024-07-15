using backend.Domain.Entities;
using backend.Domain.Repositories;
using GenericRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace backend.Application.Features.Customers.DeleteCustomerById;

internal sealed class DeleteCustomerByIdCommandHandler(
    ICustomerRepository customerRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteCustomerByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteCustomerByIdCommand request, CancellationToken cancellationToken)
    {
        Customer customer = await customerRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

        if (customer is null)
        {
            return Result<string>.Failure("Müşteri bulunamadı");
        }

        customerRepository.Delete(customer);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Müşteri başarıyla silindi";
    }
}
