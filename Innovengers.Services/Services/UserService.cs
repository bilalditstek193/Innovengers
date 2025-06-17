using Innovengers.Core.Entities;
using Innovengers.Core.Interfaces;
using Innovengers.Services.Interfaces;

namespace Innovengers.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> GetUserAsync(int id) =>
            _userRepository.GetByIdAsync(id);

        public Task CreateUserAsync(User user) =>
            _userRepository.AddAsync(user);
    }
}