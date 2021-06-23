using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Rates.Data;
using Hotel.Rates.Data.DTOs;
using Hotel.Rates.Data.Interfaces;

namespace Hotel.Rates.Infrastructure.Repositories
{
    public class RatePlanRepository : IRateRepository<RatePlan>
    {
        private readonly InventoryContext _context;

        public RatePlanRepository(InventoryContext context)
        {
            _context = context;
        }


        public IReadOnlyList<RatePlan> GetAll()
        {
            return _context.RatePlans.ToList();
        }

        public RatePlan GetById(int id)
        {
            return _context.RatePlans.FirstOrDefault(x => x.Id == id);
        }
    }
}
