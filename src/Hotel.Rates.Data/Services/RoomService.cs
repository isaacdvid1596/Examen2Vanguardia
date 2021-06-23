using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Rates.Data.DTOs;
using Hotel.Rates.Data.Interfaces;

namespace Hotel.Rates.Data.Services
{
    public class RoomService : IRoomService
    {

        
        public RoomService()
        {
            
        }
        public ServiceResult<IReadOnlyList<RoomDto>> GetAllRooms()
        {
            throw new NotImplementedException();
        }
    }
}
