namespace Conversion.Tests
{
    using Conversion;
    using System;
    using Xunit;

    public class ProgramTests
    {
        private Program _testClass;

        public ProgramTests()
        {
            _testClass = new Program();
        }

        [Fact]
        public void CanConstruct()
        {
            var instance = new Program();
            Assert.NotNull(instance);
        }

        [Fact]
        public void CanCallMain()
        {
            var args = new[] { "TestValue1645635185", "TestValue1698589912", "TestValue42501131" };
            Program.Main(args);
            //Assert.True(false, "Create or modify test");
        }

        //[Fact]
        //public void CannotCallMainWithNullArgs()
        //{
        //    Assert.Throws<ArgumentNullException>(() => Program.Main(default(string[])));
        //}

        [Fact]
        public void CanCallConvMethod()
        {
            var userInput = new[] { "TestValue1131802465", "123" };
            Program.ConvMethod(userInput);
            //Assert.True(false, "Create or modify test");
        }

        //[Fact]
        //public void CannotCallConvMethodWithNullUserInput()
        //{
        //    Assert.Throws<ArgumentNullException>(() => Program.ConvMethod(default(string[])));
        //}
    }
}