using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rates.Data
{
    public class IntervalRatePlan : RatePlan
    {
        public IntervalRatePlan()
        {
            RatePlanType = (int) Enums.RatePlanType.Interval;
        }

        public int IntervalLength { get; set; }
    }
}
