using System;
using System.Linq;
using System.Text;

public class Animal : ISoundProducable
{
    private readonly string[] genders = {"male", "female"};
    private const string ErrorMessage = "Invalid input!";

    private string name;
    private int age;
    private string gender;


    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get { return name; }
        protected set
        {
            ValidateName(value);
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        protected set
        {
            
            if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
            {
                throw new ArgumentException(ErrorMessage);
            }
            age = value;
        }
    }

    public virtual string Gender
    {
        get { return gender; }
        protected set
        {
            ValidateName(value);
            if (!genders.Contains(value.ToLower()))
            {
                throw new ArgumentException(ErrorMessage);
            }
            gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return "...";
    }

    private static void ValidateName(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            throw new ArgumentException(ErrorMessage);
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name}")
          .AppendLine($"{this.Name} {this.Age} {this.Gender}")
          .AppendLine($"{ProduceSound()}");

        var result = sb.ToString().TrimEnd();
        return result;
    }
}

