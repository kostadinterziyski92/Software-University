using System.Linq;

public class Smartphone : ICallable, IBrowsable
{
    public string Browse(string url)
    {
        if (url.Any(ch => char.IsDigit(ch)))
        {
            return "Invalid URL!";
        }
        return $"Browsing: {url}!";
    }

    public string Call(string phoneNumber)
    {
        if (phoneNumber.Any(ch => !char.IsDigit(ch)))
        {
            return "Invalid number!";
        }
        return $"Calling... {phoneNumber}";
    }
}

