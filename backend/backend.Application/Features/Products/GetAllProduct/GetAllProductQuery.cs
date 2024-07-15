using backend.Domain.Entities;
using MediatR;
using TS.Result;

namespace backend.Application.Features.Products.GetAllProduct;
public sealed record GetAllProductQuery() : IRequest<Result<List<Product>>>;
