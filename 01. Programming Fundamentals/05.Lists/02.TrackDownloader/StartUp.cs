using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.TrackDownloader
{
    class StartUp
    {
        static void Main()
        {
            var blackList = Console.ReadLine().Split();
            var list = new List<string>();

            string fileName = String.Empty;

            while ((fileName = Console.ReadLine()) != "end")
            {
                bool contains;

                foreach (var word in blackList)
                {
                    if (fileName.Contains(word))
                    {
                        break;
                    }

                    else if(word == blackList.Last())
                    {
                        list.Add(fileName);
                    }
                }

            }

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
