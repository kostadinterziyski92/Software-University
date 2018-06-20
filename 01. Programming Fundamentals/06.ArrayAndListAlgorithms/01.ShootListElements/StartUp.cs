using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _01.ShootListElements
{
    class StartUp
    {
        static void Main()
        {
            string input = String.Empty;
            var list = new List<int>();
            var removed = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                bool checkForNum = int.TryParse(input, out int num);
                if (checkForNum)
                {
                    list.Insert(0, num);
                }
                else if (input == "bang")
                {
                    var avg = list.Count > 0 ? list.Average() : 0;
                    
                    if ((int)avg != 0)
                    {
                        foreach (var item in list)
                        {
                            if (item <= avg)
                            {
                                removed = item;
                                list.Remove(item);
                                Console.WriteLine($"shot {item}");
                                for (int i = 0; i < list.Count; i++)
                                {
                                    list[i]--;
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {removed}");
                        return;
                    }
                }
            }

            if (list.Count > 0)
            {
                Console.Write($"survivors: {string.Join(" ", list)}");
            }
            else
            {
                Console.WriteLine($"you shot them all. last one standing was {removed}");
            }

            Console.WriteLine();
        }
    }
}
