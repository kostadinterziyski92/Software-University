using System;

public class Human
{
    private const int FirstNameMinLength = 3;
    private const int LastNameMinLength = 2;

    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get { return firstName; }
        protected set
        {
            IsItCapitalLetter(value);
            NameLengthRestriction(value, FirstNameMinLength);
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        protected set
        {
            IsItCapitalLetter(value);
            NameLengthRestriction(value, LastNameMinLength);
            lastName = value;
        }
    }

    private void IsItCapitalLetter(string name)
    {
        if (!char.IsUpper(name[0]))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: {name}");
        }
    }

    private void NameLengthRestriction(string name, int restriction)
    {
        if (name.Length <= restriction)
        {
            throw new ArgumentException($"Expected legth at least {restriction + 1} symbols! Argument: {name}");
        }
    }

}