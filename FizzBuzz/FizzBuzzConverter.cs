using System;

namespace FizzBuzz
{
    public class FizzBuzzConverter
    {
        private const string _fizz = "Fizz";

        public string Convert(int number)
        {
            if (IsDivisibleByThree(number))
                return _fizz;

            return number.ToString();
        }

        private static bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }
    }
}
