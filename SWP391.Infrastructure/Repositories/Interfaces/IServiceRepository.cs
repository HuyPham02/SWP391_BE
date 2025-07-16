using SWP391.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.Infrastructure.Repositories.Interfaces
{
    public interface IServiceRepository
    {
        Task AddTestServiceAsync(TestService testService);
        Task AddAdviseServiceAsync(AdviseService adviseService);
        Task<IEnumerable<TestService>> GetAllTestServicesAsync();
        Task<IEnumerable<AdviseService>> GetAllAdviseServicesAsync();
        Task<TestService?> GetTestServiceByIdAsync(int id);
        Task<AdviseService?> GetAdviseServiceByIdAsync(int id);
        Task UpdateTestServiceAsync(TestService testService);
        Task UpdateAdviseServiceAsync(AdviseService adviseService);
        Task DeleteTestServiceAsync(int id);
        Task DeleteAdviseServiceAsync(int id);

        Task<User?> GetUserByIdAsync(int userId);
    }
}
