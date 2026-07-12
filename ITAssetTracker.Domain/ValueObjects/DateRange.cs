using ITAssetTracker.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ITAssetTracker.Domain.ValueObjects;

[Owned]
public sealed record DateRange
{
    public DateOnly start { get; private set; }
    public DateOnly? end { get; private set; }

    public DateRange(DateOnly start, DateOnly? end = null)
    {
        if (end.HasValue && start >= end.Value)
            throw new BusinessRuleExceptions("This is an invalid date range");

        this.start = start;
        this.end = end;
    }

    //protected bool Equals(DateRange other)
    //{
    //    return start == other.start && end == other.end;
    //}

    //public override bool Equals(object? obj)
    //{
    //    if (obj == null || GetType() != obj.GetType()) return false;
    //    return Equals((DateRange)obj);
    //}

    //public override int GetHashCode()
    //{
    //    return HashCode.Combine(start, end);
    //}
}
