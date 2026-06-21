using ITAssetTracker.Domain.Exceptions;

namespace ITAssetTracker.Domain.ValueObjects;

public sealed record DateRange
{
    public DateOnly start;
    public DateOnly? end;

    public DateRange(DateOnly start, DateOnly? end = null)
    {
        if (start >= end)
            throw new BusinessRuleExceptions("This is an invalid date range");

        this.start = start;
        this.end = end;
    }
}
