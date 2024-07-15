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

namespace backend.Application.Features.Products.GetAllProduct;

internal sealed class GetAllProductQueryHandler(
    IProductRepository productRepository) : IRequestHandler<GetAllProductQuery, Result<List<Product>>>
{
    public async Task<Result<List<Product>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        List<Product> products = await productRepository.GetAll().OrderBy(p => p.Name).ToListAsync(cancellationToken);

        return products;
    }
}
