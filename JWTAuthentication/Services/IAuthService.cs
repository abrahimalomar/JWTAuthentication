using JWTAuthentication.Models;

namespace JWTAuthentication.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(LogInRequest model);

        Task<string> AddRoleAsync(AddRoleModel model);
    }
}
