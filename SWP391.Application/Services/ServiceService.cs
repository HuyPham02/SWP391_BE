using SWP391.Application.DTOs;
using SWP391.Application.Services.Interfaces;
using SWP391.Infrastructure.Data;
using SWP391.Infrastructure.Entities;
using SWP391.Infrastructure.Enums;
using SWP391.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.Application.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly AppDbContext _context;

        public ServiceService(IServiceRepository serviceRepository, AppDbContext context)
        {
            _serviceRepository = serviceRepository ?? throw new ArgumentNullException(nameof(serviceRepository));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddTestServiceAsync(AddTestServiceDto testServiceDto, int staffId)
        {
            var staff = await _serviceRepository.GetUserByIdAsync(staffId);
            if (staff == null || staff.Role != RoleEnum.Staff)
            {
                throw new ArgumentException("Invalid staff account.");
            }

            var testService = new TestService
            {
                TestName = testServiceDto.TestName,
                Description = testServiceDto.Description,
                Duration = testServiceDto.Duration,
                Price = testServiceDto.Price,
            };

            await _serviceRepository.AddTestServiceAsync(testService);
        }

        public async Task AddAdviseServiceAsync(AddAdviseServiceDto adviseServiceDto, int staffId)
        {
            var staff = await _serviceRepository.GetUserByIdAsync(staffId);
            if (staff == null || staff.Role != RoleEnum.Staff)
            {
                throw new ArgumentException("Invalid staff account.");
            }

            var adviseService = new AdviseService
            {
                ContactType = adviseServiceDto.ContactType,
                ConsultationType = adviseServiceDto.ConsultationType,
                Description = adviseServiceDto.Description,
                Duration = adviseServiceDto.Duration,
                Price = adviseServiceDto.Price,
            };

            await _serviceRepository.AddAdviseServiceAsync(adviseService);
        }
    }
}
