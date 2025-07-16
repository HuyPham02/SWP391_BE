using SWP391.Application.DTOs;
using SWP391.Application.Services.Interfaces;
using SWP391.Infrastructure.Entities;
using SWP391.Infrastructure.Enums;
using SWP391.Infrastructure.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace SWP391.Application.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task AddTestServiceAsync(AddTestServiceDto testServiceDto, int staffId)
        {
            var staff = await _serviceRepository.GetUserByIdAsync(staffId);
            if (staff == null || staff.Role != RoleEnum.Staff)
            {
                throw new ArgumentException("Invalid staff ID or role.");
            }

            var testService = new TestService
            {
                TestName = testServiceDto.TestName,
                Description = testServiceDto.Description,
                Duration = testServiceDto.Duration,
                Price = testServiceDto.Price
            };

            await _serviceRepository.AddTestServiceAsync(testService);
        }

        public async Task AddAdviseServiceAsync(AddAdviseServiceDto adviseServiceDto, int staffId)
        {
            var staff = await _serviceRepository.GetUserByIdAsync(staffId);
            if (staff == null || staff.Role != RoleEnum.Staff)
            {
                throw new ArgumentException("Invalid staff ID or role.");
            }

            var adviseService = new AdviseService
            {
                ConsultationType = adviseServiceDto.ConsultationType,
                Description = adviseServiceDto.Description,
                Duration = adviseServiceDto.Duration,
                Price = adviseServiceDto.Price,
            };

            await _serviceRepository.AddAdviseServiceAsync(adviseService);
        }
        public async Task DeleteTestServiceAsync(int id, int staffId)
        {
            var staff = await _serviceRepository.GetUserByIdAsync(staffId);
            if (staff == null || staff.Role != RoleEnum.Staff)
            {
                throw new ArgumentException("Invalid staff ID or role.");
            }

            await _serviceRepository.DeleteTestServiceAsync(id);
        }

        public async Task DeleteAdviseServiceAsync(int id, int staffId)
        {
            var staff = await _serviceRepository.GetUserByIdAsync(staffId);
            if (staff == null || staff.Role != RoleEnum.Staff)
            {
                throw new ArgumentException("Invalid staff ID or role.");
            }

            await _serviceRepository.DeleteAdviseServiceAsync(id);
        }

        public async Task<IEnumerable<TestService>> GetAllTestServicesAsync()
        {
            return await _serviceRepository.GetAllTestServicesAsync();
        }

        public async Task<IEnumerable<AdviseService>> GetAllAdviseServicesAsync()
        {
            return await _serviceRepository.GetAllAdviseServicesAsync();
        }

        public async Task<TestServiceDto?> GetTestServiceByIdAsync(int id)
        {
            var testService = await _serviceRepository.GetTestServiceByIdAsync(id);
            if (testService == null)
            {
                return null;
            }
            return new TestServiceDto
            {
                Id = testService.Id,
                TestName = testService.TestName,
                Description = testService.Description,
                Duration = testService.Duration,
                Price = testService.Price
            };
        }

        public async Task<AdviseServiceDto?> GetAdviseServiceByIdAsync(int id)
        {
            var adviseService = await _serviceRepository.GetAdviseServiceByIdAsync(id);
            if (adviseService == null)
            {
                return null;
            }
            return new AdviseServiceDto
            {
                Id = adviseService.Id,
                ConsultationType = adviseService.ConsultationType,
                Description = adviseService.Description,
                Duration = adviseService.Duration,
                Price = adviseService.Price
            };
        }
        public async Task UpdateTestServiceAsync(int id, UpdateTestServiceDto updateDto, int staffId)
        {
            var staff = await _serviceRepository.GetUserByIdAsync(staffId);
            if (staff == null || staff.Role != RoleEnum.Staff)
            {
                throw new ArgumentException("Invalid staff ID or role.");
            }

            var testService = await _serviceRepository.GetTestServiceByIdAsync(id);
            if (testService == null)
            {
                throw new ArgumentException("Test service not found.");
            }

            if (updateDto.TestName != null)
            {
                testService.TestName = updateDto.TestName;
            }
            if (updateDto.Description != null)
            {
                testService.Description = updateDto.Description;
            }
            if (updateDto.Duration != null)
            {
                testService.Duration = updateDto.Duration;
            }
            if (updateDto.Price.HasValue)
            {
                testService.Price = updateDto.Price.Value;
            }

            await _serviceRepository.UpdateTestServiceAsync(testService);
        }

        public async Task UpdateAdviseServiceAsync(int id, UpdateAdviseServiceDto updateDto, int staffId)
        {
            var staff = await _serviceRepository.GetUserByIdAsync(staffId);
            if (staff == null || staff.Role != RoleEnum.Staff)
            {
                throw new ArgumentException("Invalid staff ID or role.");
            }

            var adviseService = await _serviceRepository.GetAdviseServiceByIdAsync(id);
            if (adviseService == null)
            {
                throw new ArgumentException("Advise service not found.");
            }

            if (updateDto.ConsultationType != null)
            {
                adviseService.ConsultationType = updateDto.ConsultationType;
            }
            if (updateDto.Description != null)
            {
                adviseService.Description = updateDto.Description;
            }
            if (updateDto.Duration != null)
            {
                adviseService.Duration = updateDto.Duration;
            }
            if (updateDto.Price.HasValue)
            {
                adviseService.Price = updateDto.Price.Value;
            }

            await _serviceRepository.UpdateAdviseServiceAsync(adviseService);
        }
    }
}