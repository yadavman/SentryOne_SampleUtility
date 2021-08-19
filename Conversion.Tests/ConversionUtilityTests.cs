namespace Conversion.Tests
{
    using Conversion;
    using System;
    using Xunit;

    public static class ConversionUtilityTests
    {
        [Fact]
        public static void CanCallToSafeIntWithInput()
        {
            var input = "TestValue1552362043";
            var result = ConversionUtility.ToSafeInt(input);
            Assert.Equal(0,result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public static void CannotCallToSafeIntWithInputWithInvalidInput(string value)
        {
            Assert.Throws<ArgumentNullException>(() => ConversionUtility.ToSafeInt(value));
        }

        [Fact]
        public static void CanCallToSafeIntWithInputAndDefaultValue()
        {
            var input = "TestValue486365562";
            var defaultValue = 1390805129;
            var result = ConversionUtility.ToSafeInt(input, defaultValue);
            Assert.Equal(defaultValue, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public static void CannotCallToSafeIntWithInputAndDefaultValueWithInvalidInput(string value)
        {
            Assert.Throws<ArgumentNullException>(() => ConversionUtility.ToSafeInt(value, 909261578));
        }
    }
}