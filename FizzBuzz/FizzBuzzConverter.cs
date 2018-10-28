using System;

namespace FizzBuzz
{
    public class FizzBuzzConverter
    {
        private const string _fizz = "Fizz";
        private const string _buzz = "Buzz";

        public string Convert(int number)
        {
            if (IsDivisibleByThree(number))
                return _fizz;

            if (IsDivisibleByFive(number))
                return _buzz;

            return number.ToString();
        }

        private static bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
