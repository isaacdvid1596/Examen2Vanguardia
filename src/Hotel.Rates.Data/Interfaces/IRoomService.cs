using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Rates.Data.DTOs;

namespace Hotel.Rates.Data.Interfaces
{
    public interface IRoomService
    {
        //Get All Rooms Method
        ServiceResult<IReadOnlyList<RoomDto>> GetAllRooms();
    }
}
