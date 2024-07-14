using WsTeacher_Prime.Models;

namespace WsTeacher_Prime.Services.Interfaces
{
    public interface IAuthService
    {
        Task<string> LoginAsync(LoginModel loginModel);
        Task<bool> RegisterAsync(RegisterModel registerModel);
        Task<string> RefreshTokenAsync(string token);

    }
}