using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Data.Interfaces
{
    public interface IRoomRepository<T>
    {
        IReadOnlyList<T> GetAll();
    }
}
