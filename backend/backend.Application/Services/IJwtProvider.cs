using backend.Application.Features.Auth.Login;
using backend.Domain.Entities;

namespace backend.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
