using System.Linq;

public class Smartphone : ICallable, IBrowseable
{

    public string Call(string callNumber)
    {
        return ValidCallNumber(callNumber)
            ? $"Calling... {callNumber}"
            : "Invalid number!";
    }

    public string Browse(string urlAddress)
    {
        return ValidUrlAddress(urlAddress)
            ? $"Browsing: {urlAddress}!"
            : "Invalid URL!";
    }

    private bool ValidCallNumber(string callNumber)
    {
        if (callNumber.Any(char.IsDigit))
        {
            return true;
        }
        return false;
    }

    private bool ValidUrlAddress(string urlAddress)
    {
        if (urlAddress.Any(char.IsDigit))
        {
            return false;
        }
        return true;
    }

}




