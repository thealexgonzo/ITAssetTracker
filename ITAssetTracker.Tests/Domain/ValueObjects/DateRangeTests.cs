using ITAssetTracker.Domain.Exceptions;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Tests.Domain.ValueObjects;

public class DateRangeTests
{
    [Fact]
    public void Constructor_StartIsAfterEnd_ThrowsBusinessRuleException()
    {
        Assert.Throws<BusinessRuleExceptions>(() =>
        {
            new DateRange(DateOnly.Parse(DateTime.UtcNow.ToShortDateString()), DateOnly.Parse(DateTime.UtcNow.AddDays(-1).ToShortDateString()));
        });
    }

    [Fact]
    public void ValidTimeInterval()
    {
        var exception = Record.Exception(() =>
        {
            new DateRange(DateOnly.Parse(DateTime.UtcNow.ToShortDateString()), DateOnly.Parse(DateTime.UtcNow.AddHours(1).ToShortDateString()));
        });

        Assert.Null(exception);
    }
}
