using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hotel.Rates.Data;
using Hotel.Rates.Data.Interfaces;

namespace Hotel.Rates.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository<Room>
    {
        private readonly InventoryContext _context;

        public RoomRepository(InventoryContext context)
        {
            _context = context;
        }
        public IReadOnlyList<Room> GetAll()
        {
            return _context.Rooms.ToList();
        }
    }
}
