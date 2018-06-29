using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.JSONstringify
{
    class StartUp
    {
        static void Main()
        {
            var input = String.Empty;
            var students = new List<Student>();

            while ((input = Console.ReadLine()) != "stringify")
            {
                var inputParams = input.Split(new[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                var studentInfo = inputParams[0].Trim().Split(':');
                var studentName = studentInfo[0];
                var studentAge = int.Parse(studentInfo[1]);
                var grades = new List<int>();

                if (inputParams.Length > 1)
                {
                    grades = inputParams[1].Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                }

                var student = new Student(studentName, studentAge, grades);
                students.Add(student);
            }

            Console.WriteLine("[" + string.Join(", ", students) + "]");
        }
    }
}
