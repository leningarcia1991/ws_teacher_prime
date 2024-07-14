using WsTeacher_Prime.Models;

namespace WsTeacher_Prime.Repository
{
    public interface IUserRepository
    {
        Task CreateAsync(UserModel user);
        Task<UserModel> GetByIdAsync(string id);
        Task<UserModel> GetByUsernameAsync(string username);
    }
}
