using backend.Domain.Dtos;
using MediatR;
using TS.Result;

namespace backend.Application.Features.Invoices.UpdateInvoice;
public sealed record UpdateInvoiceCommand(
    Guid Id,
    DateOnly Date,
    string InvoiceNumber,
    List<InvoiceDetailDto> Details) : IRequest<Result<string>>;
