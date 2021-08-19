namespace Conversion.Tests
{
    using Conversion;
    using System;
    using Xunit;

    public class SampleCalcTests
    {
        private SampleCalc _testClass;

        public SampleCalcTests()
        {
            _testClass = new SampleCalc();
        }

        [Fact]
        public void CanConstruct()
        {
            var instance = new SampleCalc();
            Assert.NotNull(instance);
        }

        [Fact]
        public void CanCallSampleCalculator()
        {
            var input = new CalcInput { operation = Operation.Divide, Num1 = 1189510836, Num2 = 815054574 };
            var result = _testClass.SampleCalculator(input);
            //Assert.True();
        }

        [Fact]
        public void CannotCallSampleCalculatorWithNullInput()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.SampleCalculator(default(CalcInput)));
        }
    }
}