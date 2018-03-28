﻿using System.Threading;

public class Employee
{
    public string name;
    public decimal salary;
    public string position;
    public string department;
    public string email;
    public int age;

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = "n/a";
        this.age = -1;
    }

    public Employee(string name, decimal salary, string position, string department, string email)
        : this(name, salary, position, department)
    {
        this.email = email;
    }

    public Employee(string name, decimal salary, string position, string department, string email, int age)
        :this(name, salary, position, department, email)
    {
        this.age = age;
    }

    public Employee(string name, decimal salary, string position, string department, int age)
        : this(name, salary, position, department)
    {
        this.age = age;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public decimal Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }

    public string Position
    {
        get { return this.position; }
        set { this.position = value; }
    }

    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public string Department
    {
        get { return this.department; }
        set { this.department = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
}

