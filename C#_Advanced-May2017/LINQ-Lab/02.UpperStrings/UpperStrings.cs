using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UpperStrings
{
    public static void Main()
    {
        Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(w => w.ToUpper())
            .ToList()
            .ForEach(w => Console.Write(w + " "));
    }
}

