using backend.Domain.Entities;
using backend.Domain.Repositories;
using GenericRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace backend.Application.Features.RecipeDetails.DeleteRecipeDetailById;

internal sealed class DeleteRecipeDetailByIdCommandHandler(
    IRecipeDetailRepository recipeDetailRepository,
    IUnitOfWork unitOfWork) : IRequestHandler<DeleteRecipeDetailByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteRecipeDetailByIdCommand request, CancellationToken cancellationToken)
    {
        RecipeDetail recipeDetail = await recipeDetailRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);

        if (recipeDetail is null)
        {
            return Result<string>.Failure("Reçetede bu ürün bulunamadı");
        }

        recipeDetailRepository.Delete(recipeDetail);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Ürün reçeteden başarıyla silindi";
    }
}
