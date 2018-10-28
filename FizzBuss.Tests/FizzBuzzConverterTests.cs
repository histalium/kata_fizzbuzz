using FizzBuzz;
using System;
using Xunit;

namespace FizzBuss.Tests
{
    public class FizzBuzzConverterTests
    {
        [Fact]
        public void WhenNumberIsNotSpecial_ThenDoNotConvert()
        {
            var converter = new FizzBuzzConverter();
            var number = 1;

            var convertedNumber = converter.Convert(number);

            Assert.Equal("1", convertedNumber);
        }
    }
}
