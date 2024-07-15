﻿using backend.Domain.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace backend.Application.Features.Recipes.CreateRecipe;

public sealed record CreateRecipeCommand(
    Guid ProductId,
    List<RecipeDetailDto> Details) : IRequest<Result<string>>;
