using Innovengers.Core.Entities;
using System.Threading.Tasks;

namespace Innovengers.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserAsync(int id);
        Task CreateUserAsync(User user);
    }
}