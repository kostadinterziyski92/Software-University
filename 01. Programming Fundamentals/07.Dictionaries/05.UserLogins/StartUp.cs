using System;
using System.Collections.Generic;

namespace _05.UserLogins
{
    class StartUp
    {
        static void Main()
        {
            var users = new Dictionary<string, string>();
            string line = String.Empty;

            while ((line = Console.ReadLine()) != "login")
            {
                var tokens = line.Split();
                var username = tokens[0];
                var password = tokens[tokens.Length - 1];

                users[username] = password;
            }

            var count = 0;
            while ((line = Console.ReadLine()) != "end")
            {
                var tokens = line.Split();
                var username = tokens[0];
                var password = tokens[tokens.Length - 1];

                if (users.ContainsKey(username) && users[username] == password)
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    count++;
                }
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
