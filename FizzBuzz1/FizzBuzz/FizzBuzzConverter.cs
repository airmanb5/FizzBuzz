using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzConverter
    {
        public string CheckIfFizzOrBuzzOrFizzBuzz(string text, int number)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                if (number % 3 == 0)
                {
                    text += "Fizz";
                }
                if (number % 5 == 0)
                {
                    text += "Buzz";
                }

                return text;
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
