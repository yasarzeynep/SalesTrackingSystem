using backend.Domain.Entities;
using MediatR;
using TS.Result;

namespace backend.Application.Features.Productions.GetAllProduction;
public sealed record GetAllProductionQuery() : IRequest<Result<List<Production>>>;
