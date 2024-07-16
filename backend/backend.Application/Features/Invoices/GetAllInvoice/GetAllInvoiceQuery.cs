using backend.Domain.Entities;
using MediatR;
using TS.Result;

namespace backend.Application.Features.Invoices.GetAllInvoice;
public sealed record GetAllInvoiceQuery(
    int Type) : IRequest<Result<List<Invoice>>>;
