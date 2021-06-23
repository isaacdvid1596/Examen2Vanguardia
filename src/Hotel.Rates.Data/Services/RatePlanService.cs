using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Rates.Data.DTOs;
using Hotel.Rates.Data.Interfaces;

namespace Hotel.Rates.Data.Services
{
    public class RatePlanService : IRatePlanService
    {

        public RatePlanService(RatePlanRepository)
        {
            
        }

        public ServiceResult<IReadOnlyList<RatePlanDto>> GetAllRatePlans()
        {
            
        }

        public ServiceResult<RatePlanDto> GetRatePlanById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
