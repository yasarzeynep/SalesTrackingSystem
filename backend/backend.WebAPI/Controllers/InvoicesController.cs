using backend.Application.Features.Depots.CreateDepot;
using backend.Application.Features.Depots.DeleteDepotById;
using backend.Application.Features.Depots.GetAllDepot;
using backend.Application.Features.Depots.UpdateDepot;
using backend.Application.Features.Invoices.CreateInvoice;
using backend.Application.Features.Invoices.DeleteInvoiceById;
using backend.Application.Features.Invoices.GetAllInvoice;
using backend.Application.Features.Invoices.UpdateInvoice;
using backend.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace backend.WebAPI.Controllers;

public sealed class InvoicesController : ApiController
{
    public InvoicesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllInvoiceQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateInvoiceCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(DeleteInvoiceByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateInvoiceCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}
