﻿using backend.Domain.Entities;
using backend.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace backend.Application.Features.RecipeDetails.GetRecipeByIdWithDetails;

internal sealed class GetRecipeByIdWithDetailsQueryHandler(
    IRecipeRepository recipeRepository) : IRequestHandler<GetRecipeByIdWithDetailsQuery, Result<Recipe>>
{
    public async Task<Result<Recipe>> Handle(GetRecipeByIdWithDetailsQuery request, CancellationToken cancellationToken)
    {
        Recipe? recipe =
            await recipeRepository
            .Where(p => p.Id == request.RecipeId)
            .Include(p => p.Product)
             .Include(p => p.Details!.OrderBy(p => p.Product!.Name))
            .ThenInclude(p => p.Product)
            .FirstOrDefaultAsync(cancellationToken);

        if (recipe is null)
        {
            return Result<Recipe>.Failure("Ürüne ait reçete bulunamadı");
        }

        return recipe;
    }
}
