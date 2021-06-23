using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Rates.Data.DTOs;

namespace Hotel.Rates.Data.Interfaces
{
    public interface IRatePlanService
    {
        ServiceResult<IReadOnlyList<RatePlanDto>> GetAllRatePlans();
        ServiceResult<RatePlanDto> GetRatePlanById(int id);
    }
}
