using System;

class StartUp
{
    static void Main()
    {
        try
        {
            var studentTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var studentFirstName = studentTokens[0];
            var studentLastName = studentTokens[1];
            var studentFacultyNumber = studentTokens[2];

            var workerTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var workerFirstName = workerTokens[0];
            var workerLastName = workerTokens[1];
            var workerSalary = decimal.Parse(workerTokens[2]);
            var workerHours = int.Parse(workerTokens[3]);

            var student = new Student(studentFirstName, studentLastName, studentFacultyNumber);
            var worker = new Worker(workerFirstName, workerLastName, workerSalary, workerHours);

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

