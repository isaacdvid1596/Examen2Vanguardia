using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Data.Enums
{
    public enum ResponseCode
    {
        Success,
        Error,
        InternalServerError = 500,
        NotFound
    }
}
