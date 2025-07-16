using SWP391.Application.DTOs;
using SWP391.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.Application.Services.Interfaces
{
    public interface IServiceService
    {
        Task AddTestServiceAsync(AddTestServiceDto testServiceDto, int staffId);
        Task AddAdviseServiceAsync(AddAdviseServiceDto adviseServiceDto, int staffId);
        Task DeleteTestServiceAsync(int id, int staffId);
        Task DeleteAdviseServiceAsync(int id, int staffId);
        Task<IEnumerable<TestService>> GetAllTestServicesAsync();
        Task<IEnumerable<AdviseService>> GetAllAdviseServicesAsync();
        Task<TestServiceDto?> GetTestServiceByIdAsync(int id);
        Task<AdviseServiceDto?> GetAdviseServiceByIdAsync(int id);
        Task UpdateTestServiceAsync(int id, UpdateTestServiceDto testServiceDto, int staffId);
        Task UpdateAdviseServiceAsync(int id, UpdateAdviseServiceDto adviseServiceDto, int staffId);
    }
}
