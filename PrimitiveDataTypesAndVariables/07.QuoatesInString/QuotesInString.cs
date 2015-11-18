using System;

class QuotesInString
{
    static void Main()
    {
        string first = "The \"use\" of quotations causes difficulties.";
        string second = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(first);
        Console.WriteLine(second);
    }
}

