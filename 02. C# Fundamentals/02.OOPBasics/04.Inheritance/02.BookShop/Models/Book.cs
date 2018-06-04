using System;
using System.Text;

public class Book
{
    private string author;
    private string title;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Title
    {
        get
        {
            return title;
        }
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public string Author
    {
        get
        {
            return author;
        }
        protected set
        {
            var names = value.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            if (names.Length > 1 && char.IsDigit(names[1][0]))
            {
                throw new ArgumentException("Author not valid!");
            }
            author = value;
        }
    }
    
    public virtual decimal Price
    {
        get
        {
            return price;
        }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public override string ToString()
    {
        var strBuilder = new StringBuilder();
        strBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
        string result = strBuilder.ToString().TrimEnd();
        return result;
    }
}

