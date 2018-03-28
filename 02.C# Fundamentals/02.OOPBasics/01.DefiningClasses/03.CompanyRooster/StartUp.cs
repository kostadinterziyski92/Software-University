using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _03.CompanyRooster
{
    class StartUp
    {
        static void Main()
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[numberOfEmployees];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var employeeInfo = Console.ReadLine().Split();
                var name = employeeInfo[0];
                var salary = decimal.Parse(employeeInfo[1]);
                var position = employeeInfo[2];
                var department = employeeInfo[3];

                if (employeeInfo.Length == 4)
                {
                    employees[i] = new Employee(name, salary, position, department);
                }
                else if (employeeInfo.Length == 6)
                {
                    var email = employeeInfo[4];
                    var age = int.Parse(employeeInfo[5]);
                    employees[i] = new Employee(name, salary, position, department, email, age);
                }
                else
                {
                    var age = 0;
                    var emailOrAge = int.TryParse(employeeInfo[4], out age);
                    if (emailOrAge)
                    {
                        employees[i] = new Employee(name, salary, position, department, age);
                    }
                    else
                    {
                        var email = employeeInfo[4];
                        employees[i] = new Employee(name, salary, position, department, email);
                    }
                }
            }
            
            var salaries = new Dictionary<string, decimal>();
            foreach (var employee in employees)
            {
                if (!salaries.ContainsKey(employee.department))
                {
                    salaries.Add(employee.department, employee.salary);
                }
                else
                {
                    salaries[employee.department] += employee.salary;
                }
            }

            decimal highestAverageSalary = decimal.MinValue;
            string highestPaidDepartment = "";

            foreach (string department in salaries.Keys)
            {
                decimal averageSalary = salaries[department] / employees.Where(e => e.department == department).Count();
                if (averageSalary > highestAverageSalary)
                {
                    highestAverageSalary = averageSalary;
                    highestPaidDepartment = department;
                }
            }

            Console.WriteLine($"Highest Average salary: {highestPaidDepartment}");
            foreach (var employee in employees.Where(e => e.department == highestPaidDepartment).OrderByDescending(e => e.salary))
            {
                Console.WriteLine($"{employee.name} {employee.salary:f2} {employee.email} {employee.age}");
            }
        }
    }
}
