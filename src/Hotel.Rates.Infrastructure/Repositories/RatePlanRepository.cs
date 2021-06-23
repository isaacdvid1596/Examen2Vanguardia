using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Rates.Data;
using Hotel.Rates.Data.DTOs;

namespace Hotel.Rates.Infrastructure.Repositories
{
    public class RatePlanRepository
    {
        private readonly InventoryContext _context;

        public RatePlanRepository(InventoryContext context)
        {
            _context = context;
        }

        public IReadOnlyList<RatePlan> GetRooms()
        {
            return _context.RatePlans.ToList();
        }
    }
}
