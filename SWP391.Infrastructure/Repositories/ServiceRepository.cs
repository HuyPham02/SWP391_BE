using Microsoft.EntityFrameworkCore;
using SWP391.Infrastructure.Data;
using SWP391.Infrastructure.Entities;
using SWP391.Infrastructure.Enums;
using SWP391.Infrastructure.Repositories.Interfaces;
using System.Threading.Tasks;

namespace SWP391.Infrastructure.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly AppDbContext _context;

        public ServiceRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddTestServiceAsync(TestService testService)
        {
            await _context.TestServices.AddAsync(testService);
            await _context.SaveChangesAsync();
        }

        public async Task AddAdviseServiceAsync(AdviseService adviseService)
        {
            await _context.AdviseServices.AddAsync(adviseService);
            await _context.SaveChangesAsync();
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
        }
    }
}