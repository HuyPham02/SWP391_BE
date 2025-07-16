using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391.Api.Models;
using SWP391.Application.DTOs;
using SWP391.Application.Services.Interfaces;
using SWP391.Infrastructure.Entities;
using System.Security.Claims;

namespace SWP391.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet("test-services")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> GetAllTestServices()
        {
            try
            {
                var testServices = await _serviceService.GetAllTestServicesAsync();
                return Ok(ApiResponse<IEnumerable<TestService>>.Success(testServices, "Lấy danh sách dịch vụ kiểm tra thành công."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }

        [HttpGet("advise-services")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> GetAllAdviseServices()
        {
            try
            {
                var adviseServices = await _serviceService.GetAllAdviseServicesAsync();
                return Ok(ApiResponse<IEnumerable<AdviseService>>.Success(adviseServices, "Lấy danh sách dịch vụ tư vấn thành công."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }

        [HttpGet("test-service/{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> GetTestServiceById(int id)
        {
            try
            {
                var testServiceDto = await _serviceService.GetTestServiceByIdAsync(id);
                if (testServiceDto == null)
                {
                    return NotFound(ApiResponse<object>.Error(404, "Dịch vụ kiểm tra không tồn tại."));
                }
                return Ok(ApiResponse<TestServiceDto>.Success(testServiceDto, "Lấy thông tin dịch vụ kiểm tra thành công."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }

        [HttpGet("advise-service/{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> GetAdviseServiceById(int id)
        {
            try
            {
                var adviseServiceDto = await _serviceService.GetAdviseServiceByIdAsync(id);
                if (adviseServiceDto == null)
                {
                    return NotFound(ApiResponse<object>.Error(404, "Dịch vụ tư vấn không tồn tại."));
                }
                return Ok(ApiResponse<AdviseServiceDto>.Success(adviseServiceDto, "Lấy thông tin dịch vụ tư vấn thành công."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }

        [HttpPost("test-service")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> AddTestService([FromBody] AddTestServiceDto testServiceDto)
        {
            try
            {
                var staffIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(staffIdClaim) || !int.TryParse(staffIdClaim, out int staffId))
                {
                    return Unauthorized(ApiResponse<object>.Error(401, "Xác thực nhân viên không hợp lệ."));
                }

                await _serviceService.AddTestServiceAsync(testServiceDto, staffId);
                return Ok(ApiResponse<object>.Success(null, "Dịch vụ kiểm tra được thêm thành công."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ApiResponse<object>.Error(400, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }

        [HttpPost("advise-service")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> AddAdviseService([FromBody] AddAdviseServiceDto adviseServiceDto)
        {
            try
            {
                var staffIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(staffIdClaim) || !int.TryParse(staffIdClaim, out int staffId))
                {
                    return Unauthorized(ApiResponse<object>.Error(401, "Xác thực nhân viên không hợp lệ."));
                }

                await _serviceService.AddAdviseServiceAsync(adviseServiceDto, staffId);
                return Ok(ApiResponse<object>.Success(null, "Dịch vụ tư vấn được thêm thành công."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ApiResponse<object>.Error(400, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }
        [HttpPut("test-service/{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> UpdateTestService(int id, [FromBody] UpdateTestServiceDto updateDto)
        {
            try
            {
                var staffIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(staffIdClaim) || !int.TryParse(staffIdClaim, out int staffId))
                {
                    return Unauthorized(ApiResponse<object>.Error(401, "Xác thực nhân viên không hợp lệ."));
                }

                await _serviceService.UpdateTestServiceAsync(id, updateDto, staffId);
                return Ok(ApiResponse<object>.Success(null, "Dịch vụ kiểm tra được cập nhật thành công."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ApiResponse<object>.Error(400, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }

        [HttpPut("advise-service/{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> UpdateAdviseService(int id, [FromBody] UpdateAdviseServiceDto updateDto)
        {
            try
            {
                var staffIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(staffIdClaim) || !int.TryParse(staffIdClaim, out int staffId))
                {
                    return Unauthorized(ApiResponse<object>.Error(401, "Xác thực nhân viên không hợp lệ."));
                }

                await _serviceService.UpdateAdviseServiceAsync(id, updateDto, staffId);
                return Ok(ApiResponse<object>.Success(null, "Dịch vụ tư vấn được cập nhật thành công."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ApiResponse<object>.Error(400, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }
        [HttpDelete("test-service/{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> DeleteTestService(int id)
        {
            try
            {
                var staffIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(staffIdClaim) || !int.TryParse(staffIdClaim, out int staffId))
                {
                    return Unauthorized(ApiResponse<object>.Error(401, "Xác thực nhân viên không hợp lệ."));
                }

                await _serviceService.DeleteTestServiceAsync(id, staffId);
                return Ok(ApiResponse<object>.Success(null, "Dịch vụ kiểm tra được xóa thành công."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ApiResponse<object>.Error(400, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }

        [HttpDelete("advise-service/{id}")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> DeleteAdviseService(int id)
        {
            try
            {
                var staffIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(staffIdClaim) || !int.TryParse(staffIdClaim, out int staffId))
                {
                    return Unauthorized(ApiResponse<object>.Error(401, "Xác thực nhân viên không hợp lệ."));
                }

                await _serviceService.DeleteAdviseServiceAsync(id, staffId);
                return Ok(ApiResponse<object>.Success(null, "Dịch vụ tư vấn được xóa thành công."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ApiResponse<object>.Error(400, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"Đã xảy ra lỗi: {ex.Message}"));
            }
        }
    }
}
