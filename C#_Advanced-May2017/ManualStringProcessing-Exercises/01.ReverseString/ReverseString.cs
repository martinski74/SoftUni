using System;

public class ReverseString
{
    public static void Main()
    {
        var input = Console.ReadLine().ToCharArray();
        Array.Reverse(input);
        Console.WriteLine(input);
    }
}

