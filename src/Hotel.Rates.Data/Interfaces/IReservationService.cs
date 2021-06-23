using System.Collections.Generic;

namespace Hotel.Rates.Data.Interfaces
{
    public interface IReservationService
    {
        //Create Reservation Method

        ServiceResult<ReservationDto> CreateReservation()
    }
}
