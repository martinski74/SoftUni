using System;

public class Program
{
    public static void Main()
    {
        var enumType = Console.ReadLine();

        Type type = null;
        if (enumType == "Rank")
        {
            type = typeof(Rank);
        }
        else
        {
            type = typeof(Suit);
        }

        var attributes = type.GetCustomAttributes(false);

        foreach (var attribute in attributes)
        {
            Console.WriteLine(attribute.ToString());
        }
    }
}

