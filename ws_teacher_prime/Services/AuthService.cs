using WsTeacher_Prime.Models;
using WsTeacher_Prime.Repository;
using WsTeacher_Prime.Services.Interfaces;
using WsTeacher_Prime.Utils;

namespace WsTeacher_Prime.Services
{
    public class AuthService : IAuthService
    {
        // Esto debería ser una referencia a tu base de datos
        private readonly IUserRepository _userRepository;
        private readonly IJwtUtils _jwtUtils;

        public AuthService(IUserRepository userRepository, IJwtUtils jwtUtils)
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
        }

        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            var user = await _userRepository.GetByUsernameAsync(loginModel.Username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(loginModel.Password, user.PasswordHash))
                return null;

            var token = _jwtUtils.GenerateJwtToken(user);
            return token;
        }

        public async Task<bool> RegisterAsync(RegisterModel registerModel)
        {
            var existingUser = await _userRepository.GetByUsernameAsync(registerModel.Username);
            if (existingUser != null)
                return false;

            var user = new UserModel
            {
                Username = registerModel.Username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerModel.Password)
            };

            await _userRepository.CreateAsync(user);
            return true;
        }

        public async Task<string> RefreshTokenAsync(string token)
        {
            var validatedToken = _jwtUtils.ValidateJwtToken(token);
            if (validatedToken == null)
                return null;

            var user = await _userRepository.GetByIdAsync(validatedToken.Id);
            if (user == null)
                return null;

            var newToken = _jwtUtils.GenerateJwtToken(user);
            return newToken;
        }
    }
}
