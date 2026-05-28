using ITAssetTracker.Domain.Exceptions;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Tests.Domain.ValueObjects
{
    public class DateRangeTests
    {
        [Fact]
        public void Constructor_StartIsAfterEnd_ThrowsBusinessRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
            {
                new DateRange(DateTime.UtcNow, DateTime.UtcNow.AddDays(-1));
            });
        }

        [Fact]
        public void ValidTimeInterval()
        {
            var exception = Record.Exception(() =>
            {
                new DateRange(DateTime.UtcNow, DateTime.UtcNow.AddHours(1));
            });

            Assert.Null(exception);
        }
    }
}
