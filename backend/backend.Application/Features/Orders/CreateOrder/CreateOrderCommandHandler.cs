using AutoMapper;
using backend.Domain.Entities;
using backend.Domain.Repositories;
using GenericRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace backend.Application.Features.Orders.CreateOrder;

internal sealed class CreateOrderCommandHandler(
    IOrderRepository orderRepository,
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateOrderCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        Order? lastOrder =
            await orderRepository
            .Where(p => p.OrderNumberYear == request.Date.Year)
            .OrderByDescending(p => p.OrderNumber)
            .FirstOrDefaultAsync(cancellationToken);

        int lastOrderNumber = 0;

        if (lastOrder is not null) lastOrderNumber = lastOrder.OrderNumber;

        Order order = mapper.Map<Order>(request);
        order.OrderNumber = lastOrderNumber + 1;
        order.OrderNumberYear = request.Date.Year;

        await orderRepository.AddAsync(order, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Sipariş başarıyla oluşturuldu";
    }
}