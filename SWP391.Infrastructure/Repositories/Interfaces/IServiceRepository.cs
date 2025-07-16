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
        Task<User?> GetUserByIdAsync(int userId);
    }
}
