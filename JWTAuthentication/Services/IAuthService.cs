using JWTAuthentication.Models;

namespace JWTAuthentication.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> LoginAsync(LogInRequest model);

        Task<string> AddRoleAsync(AddRoleModel model);

        Task<AuthModel> RefreshTokenAsync(string token);
        Task<bool> RevokeTokenAsync(string token);
    }
}
