using System;

namespace _12.VariableInHexadecimalFormat
{
    class VariableHexadecimalFormat
    {
        static void Main()
        {
            string hexadecimal = Console.ReadLine();

            int convertedToDecimal = Convert.ToInt32(hexadecimal, 16);

            Console.WriteLine(convertedToDecimal);
        }
    }
}
