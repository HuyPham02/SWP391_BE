using Microsoft.EntityFrameworkCore;
using SWP391.Infrastructure.Data;
using SWP391.Infrastructure.Entities;
using SWP391.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
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

        public async Task<IEnumerable<TestService>> GetAllTestServicesAsync()
        {
            return await _context.TestServices.ToListAsync();
        }

        public async Task<IEnumerable<AdviseService>> GetAllAdviseServicesAsync()
        {
            return await _context.AdviseServices.ToListAsync();
        }

        public async Task<TestService?> GetTestServiceByIdAsync(int id)
        {
            return await _context.TestServices.FindAsync(id);
        }

        public async Task<AdviseService?> GetAdviseServiceByIdAsync(int id)
        {
            return await _context.AdviseServices.FindAsync(id);
        }

        public async Task UpdateTestServiceAsync(TestService testService)
        {
            _context.TestServices.Update(testService);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAdviseServiceAsync(AdviseService adviseService)
        {
            _context.AdviseServices.Update(adviseService);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTestServiceAsync(int id)
        {
            var testService = await _context.TestServices.FindAsync(id);
            if (testService != null)
            {
                _context.TestServices.Remove(testService);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAdviseServiceAsync(int id)
        {
            var adviseService = await _context.AdviseServices.FindAsync(id);
            if (adviseService != null)
            {
                _context.AdviseServices.Remove(adviseService);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }
    }
}