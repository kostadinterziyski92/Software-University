using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01.ActionPoint
{
    class ActionPoint
    {
        static void Main()
        {
            var names = Console.ReadLine().Split(' ').ToList();

            Action<string> PrintName = (s) => Console.WriteLine(s);

            names.ForEach(PrintName);
        }
    }
}
