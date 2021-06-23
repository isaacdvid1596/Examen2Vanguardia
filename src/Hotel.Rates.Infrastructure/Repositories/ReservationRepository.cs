using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Rates.Data.Interfaces;
using Hotel.Rates.Data.Models;

namespace Hotel.Rates.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository<ReservationModel>
    {
        private readonly InventoryContext _context;

        public ReservationRepository(InventoryContext context)
        {
            _context = context;
        }
        public void Add(ReservationModel entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
    }
}
