using ITAssetTracker.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITAssetTracker.Domain.ValueObjects
{
    public class DateRange
    {
        private readonly DateTime start;
        private readonly DateTime end;

        public DateRange(DateTime start, DateTime end)
        {
            if(start > end)
            {
                throw new BusinessRuleExceptions("This is an invalid date range");
            }

            this.start = start;
            this.end = end;
        }
    }
}
