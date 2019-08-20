using System;

namespace FizzBuzzCSharp
{
    public class FizzBuzz
    {

        static void Main()
        {

        }

        public string Play(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}
