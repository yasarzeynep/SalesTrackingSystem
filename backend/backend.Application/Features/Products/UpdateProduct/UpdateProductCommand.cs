using MediatR;
using TS.Result;

namespace backend.Application.Features.Products.UpdateProduct;
public sealed record UpdateProductCommand(
    Guid Id,
    string Name,
    int TypeValue) : IRequest<Result<string>>;
