using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Rates.Data.DTOs;
using Hotel.Rates.Data.Interfaces;

namespace Hotel.Rates.Data.Services
{
    public class RatePlanService : IRatePlanService
    {
        private readonly IRateRepository<RatePlan> _rateRepository;

        public RatePlanService(IRateRepository<RatePlan> rateRepository)
        {
            _rateRepository = rateRepository;
        }

        public ServiceResult<IReadOnlyList<RatePlanDto>> GetAllRatePlans()
        {
           var rates = _rateRepository.GetAll().Select(x => new RatePlanDto
            {
                Name = x.Name,
                Price = x.Price,
                RatePlanType = x.RatePlanType,
                Seasons = x.Seasons
            });
           return ServiceResult<IReadOnlyList<RatePlanDto>>.SuccessResult(rates.ToList());
        }

        public ServiceResult<RatePlanDto> GetRatePlanById(int id)
            {
        //    var rate = _rateRepository.GetAll.Select(x => new RatePlanDto
        //    {
        //        Name = x.Name,
        //        Price = x.Price,
        //        RatePlanType = x.RatePlanType,
        //        Seasons = x.Seasons
        //    }).Where(x => x.Id == id);

            var rate = _rateRepository.GetById(id);

            var rates = new RatePlanDto
            {
                Name = rate.Name,
                Price = rate.Price,
                RatePlanType = rate.RatePlanType,
                Seasons = rate.Seasons
            };

            if (rates == null)
            {
                return ServiceResult<RatePlanDto>.ErrorResult($"Rate with id {id} cannot be found");
            }

            return ServiceResult<RatePlanDto>.SuccessResult(rates);
        }
    }
}
