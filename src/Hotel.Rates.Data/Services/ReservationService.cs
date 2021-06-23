using System;
using System.Collections.Generic;
using System.Text;
using Hotel.Rates.Data.DTOs;
using Hotel.Rates.Data.Interfaces;
using Hotel.Rates.Data.Models;

namespace Hotel.Rates.Data.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository<ReservationModel> _reservationRepository;

        public ReservationService(IReservationRepository<ReservationModel> reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }
        public ServiceResult<bool> CreateReservation()
        {
            return ServiceResult<bool>.SuccessResult(true);
        }
    }
}
