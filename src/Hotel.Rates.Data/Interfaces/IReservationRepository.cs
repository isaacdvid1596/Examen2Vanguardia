using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Data.Interfaces
{
    public interface IReservationRepository<T>
    {
        void Add(T entity);
    }
}
