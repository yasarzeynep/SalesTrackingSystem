using backend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace backend.Application.Features.Recipes.GetAllRecipe;

public sealed record GetAllRecipeQuery() : IRequest<Result<List<Recipe>>>;
