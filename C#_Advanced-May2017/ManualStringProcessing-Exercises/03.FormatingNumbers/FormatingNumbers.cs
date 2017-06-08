using System;
using System.Collections.Generic;

public class FormatingNumbers
{
    public static void Main()
    {
        var input = Console.ReadLine().Trim()
            .Split(new[] { ' ','\t','\n','\r' }, StringSplitOptions.RemoveEmptyEntries);
        int a = int.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        Console.Write("|{0,-10}|", a.ToString("X"));
        Console.Write("{0}|", Convert.ToString(a, 2).PadLeft(10, '0').Substring(0,10));
        Console.Write("{0,10:0.00}|", b);
        Console.WriteLine("{0,-10:0.000}|", c);
    }
}

