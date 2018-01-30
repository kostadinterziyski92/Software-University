using System;
using System.Runtime.InteropServices;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                var successOrError = Console.ReadLine();

                if (successOrError == "success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();
                    var success = ShowSuccess(operation, message);

                    Console.WriteLine(success);
                }
                else if (successOrError == "error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());
                    var error = ShowError(operation, code);

                    Console.WriteLine(error);
                }
            }
        }

        private static string ShowError(string operation, int code)
        {
            if (code > 0)
            {
                var errorText1 =
                    $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Invalid Client Data";
                return errorText1;
            }
            else
            {
                var errorText =
                    $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: Internal System Failure";
                return errorText;
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            var successText =
                $"Successfully executed {operation}.\n==============================\nMessage: {message}.";
            return successText;
        }
    }
}
