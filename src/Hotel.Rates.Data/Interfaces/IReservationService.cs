using System.Collections.Generic;
using Hotel.Rates.Data.DTOs;

namespace Hotel.Rates.Data.Interfaces
{
    public interface IReservationService
    {
        //Create Reservation Method
        ServiceResult<bool> CreateReservation();
    }
}
