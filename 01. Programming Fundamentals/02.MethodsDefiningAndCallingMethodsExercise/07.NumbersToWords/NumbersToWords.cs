using System;
using System.Collections.Generic;
using System.Text;

namespace _07.NumbersToWords
{
    class NumersToWords
    {
        static void Main()
        {
            var numbersCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbersCount; i++)
            {
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine(Letterize(number));
            }

        }

        static string Letterize(int number)
        {
            var thirdNumber = number % 10;
            var secondNumber = (number / 10) % 10;
            var firstNumber = (((number / 10) / 10) % 10);
            string[] oneToTwenty = new[]
            {
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
            };
            string[] tenToTwenty = new[]
            {
                "eleven", "twelve",
                "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
            };
            string[] roundNumbers = new[]
            {
                "zero", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
            };

            
            string result = String.Empty;
            if (number > 999)
            {
                result = "too large";
                return result;
            }
            else if (number < -999)
            {
                result = "too small";
                return result;
            }
            else
            {
                if (secondNumber != 1)
                {
                    result = oneToTwenty[firstNumber] + " - hundred " + roundNumbers[secondNumber] + " " + oneToTwenty[thirdNumber];
                    return result;
                }
                else
                {
                    result = oneToTwenty[firstNumber] + " - hundred " + tenToTwenty[secondNumber];
                    return result;
                }
                
            }
            

        }
    }
}
