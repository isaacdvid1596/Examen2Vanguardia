using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Data.Interfaces
{
    public interface IRateRepository<T>
    {
        IReadOnlyList<T> GetAll();

        T GetById(int id);
    }
}
