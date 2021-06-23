using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Data.DTOs
{
    public class RoomDto
    {
        public int MaxAdults { get; set; }

        public int MaxChildren { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }
    }
}
