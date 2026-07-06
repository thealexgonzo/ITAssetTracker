using ITAssetTracker.Domain.Entities;
using ITAssetTracker.Domain.Exceptions;
using ITAssetTracker.Domain.ValueObjects;

namespace ITAssetTracker.Tests.Domain.Entities
{
    public class AssetTests
    {

        private Asset CreateValidAsset(
            string? tag = "IT-LAPTOP-0142",
            string? name = "Test Name",
            decimal price = 1299.99m,
            string? location = "Head Office - Floor 2",
            string? serialNumber = "DL7440-9XK21P",
            string? description = "Assigned to finance department.")
        {
            return new Asset(
                tag: tag!,
                name: name!,
                assetProductId: 1,
                assetStatusId: 2,
                price: price,
                location: location!,
                serialNumber: serialNumber!,
                purchaseDate: new DateOnly(2023, 1, 10),
                warrantyExpiryDate: new DateOnly(2026, 1, 10),
                description: description!
            );
        }

        [Fact]
        public void Constructor_NullTag_ThrowsBusinessRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
                CreateValidAsset(tag: null));
        }

        [Fact]
        public void Constructor_EmptyTag_ThrowsBusinessRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
                CreateValidAsset(tag: ""));
        }

        [Fact]
        public void Constructor_NullName_ThrowsBusinesRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
            {
                var asset = CreateValidAsset(name: null);
            });
        }

        [Fact]
        public void Constructor_EmptyName_ThrowsBusinesRuleException()
        {

            Assert.Throws<BusinessRuleExceptions>(() =>
            {
                var asset = CreateValidAsset(name: "");
            });
        }

        [Fact]
        public void Constructor_ZeroPrice_ThrowsBusinessRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
                CreateValidAsset(price: 0));
        }

        [Fact]
        public void Constructor_NegativePrice_ThrowsBusinessRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
                CreateValidAsset(price: -100));
        }

        [Fact]
        public void Constructor_NullLocation_ThrowsBusinessRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
                CreateValidAsset(location: null));
        }

        [Fact]
        public void Constructor_EmptyLocation_ThrowsBusinessRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
                CreateValidAsset(location: ""));
        }

        [Fact]
        public void Constructor_NullSerialNumber_ThrowsBusinessRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
                CreateValidAsset(serialNumber: null));
        }

        [Fact]
        public void Constructor_EmptySerialNumber_ThrowsBusinessRuleException()
        {
            Assert.Throws<BusinessRuleExceptions>(() =>
                CreateValidAsset(serialNumber: ""));
        }

        [Fact]
        public void Constructor_ValidAsset()
        {
            Exception exception = Record.Exception(() =>
            {
                Asset asset = CreateValidAsset();
            });

            Assert.Null(exception);
        }
    }
}
