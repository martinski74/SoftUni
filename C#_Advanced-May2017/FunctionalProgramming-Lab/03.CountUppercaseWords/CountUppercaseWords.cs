using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CountUppercaseWords
{
    public static void Main()
    {
        Func<string, bool> IsUppercase = x => char.IsUpper(x[0]);
        Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
         .Where(IsUppercase)
         .ToList()
         .ForEach(x => Console.WriteLine(x));

    }
}

