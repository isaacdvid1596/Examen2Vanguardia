using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Data.DTOs
{
    public class RatePlanDto
    {
        public string Name { get; set; }

        public int RatePlanType { get; set; }

        public double Price { get; set; }

        public ICollection<Season> Seasons { get; set; }
    }
}
