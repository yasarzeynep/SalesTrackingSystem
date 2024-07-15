﻿using AutoMapper;
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

namespace backend.Application.Features.Customers.CreateCusromer;

internal sealed class CreateCustomerCommandHandler(
    ICustomerRepository customerRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateCustomerCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        bool isTaxNumberExists = await customerRepository.AnyAsync(p => p.TaxNumber == request.TaxNumber, cancellationToken);

        if (isTaxNumberExists)
        {
            return Result<string>.Failure("Vergi numarası daha önce kaydedilmiş");
        }

        Customer customer = mapper.Map<Customer>(request);

        await customerRepository.AddAsync(customer, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Müşteri kaydı başarıyla tamamlandı";
    }
}