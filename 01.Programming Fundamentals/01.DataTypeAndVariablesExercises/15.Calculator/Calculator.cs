using System;

namespace _15.Calculator
{
    class Calculator
    {
        static void Main()
        {
            int operand1 = int.Parse(Console.ReadLine());
            string operatorr = Console.ReadLine();
            int operand2 = int.Parse(Console.ReadLine());
            int result;

            switch (operatorr)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = operand1 / operand2;
                    Console.WriteLine(result);
                    break;
                    default: Console.WriteLine("Enter valid operands and operator!");
                    break;
            }
        }
    }
}
