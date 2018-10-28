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

        [Fact]
        public void WhenDivisibleByThree_ThenConvertToFizz()
        {
            var converter = new FizzBuzzConverter();
            var number = 3;

            var convertedNumber = converter.Convert(number);

            Assert.Equal("Fizz", convertedNumber);
        }

        [Fact]
        public void WhenDivisibleByFive_ThenConvertToBuzz()
        {
            var converter = new FizzBuzzConverter();
            var number = 5;

            var convertedNumber = converter.Convert(number);

            Assert.Equal("Buzz", convertedNumber);
        }

        [Fact]
        public void WhenDivisibleByThreeAndFive_ThenConvertToFizzBuzz()
        {
            var converter = new FizzBuzzConverter();
            var number = 15;

            var convertedNumber = converter.Convert(number);

            Assert.Equal("FizzBuzz", convertedNumber);
        }
    }
}
