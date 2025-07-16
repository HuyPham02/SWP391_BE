using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391.Api.Models;
using SWP391.Application.DTOs;
using SWP391.Application.Services.Interfaces;

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

        [HttpPost("test-service")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> AddTestService([FromBody] AddTestServiceDto testServiceDto)
        {
            try
            {
                var staffIdClaim = User.FindFirst("sub")?.Value;
                if (string.IsNullOrEmpty(staffIdClaim) || !int.TryParse(staffIdClaim, out int staffId))
                {
                    return Unauthorized(ApiResponse<object>.Error(401, "Invalid staff authentication."));
                }

                await _serviceService.AddTestServiceAsync(testServiceDto, staffId);
                return Ok(ApiResponse<object>.Success(null, "Test service added successfully."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ApiResponse<object>.Error(400, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"An error occurred: {ex.Message}"));
            }
        }

        [HttpPost("advise-service")]
        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> AddAdviseService([FromBody] AddAdviseServiceDto adviseServiceDto)
        {
            try
            {
                var staffIdClaim = User.FindFirst("sub")?.Value;
                if (string.IsNullOrEmpty(staffIdClaim) || !int.TryParse(staffIdClaim, out int staffId))
                {
                    return Unauthorized(ApiResponse<object>.Error(401, "Invalid staff authentication."));
                }

                await _serviceService.AddAdviseServiceAsync(adviseServiceDto, staffId);
                return Ok(ApiResponse<object>.Success(null, "Advise service added successfully."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ApiResponse<object>.Error(400, ex.Message));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ApiResponse<object>.Error(500, $"An error occurred: {ex.Message}"));
            }
        }
    }
}
