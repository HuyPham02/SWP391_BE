using SWP391.Application.DTOs;
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
    }
}
