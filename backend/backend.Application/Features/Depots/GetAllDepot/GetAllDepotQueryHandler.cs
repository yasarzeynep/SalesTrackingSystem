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

namespace backend.Application.Features.Depots.GetAllDepot;

internal sealed class GetAllDepotQueryHandler(
    IDepotRepository depotRepository) : IRequestHandler<GetAllDepotQuery, Result<List<Depot>>>
{
    public async Task<Result<List<Depot>>> Handle(GetAllDepotQuery request, CancellationToken cancellationToken)
    {
        List<Depot> depots = await depotRepository.GetAll().OrderBy(p => p.Name).ToListAsync(cancellationToken);

        return depots;
    }
}