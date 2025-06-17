using Microsoft.EntityFrameworkCore;
using Innovengers.Core.Entities;
using Innovengers.Core.Interfaces;
using Innovengers.Infrastructure.Data;

namespace Innovengers.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(int id) =>
            await _context.Users.FindAsync(id);

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
