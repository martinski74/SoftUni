using System;

class NumberComarer
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Greater is: {0}", Math.Max(a, b));
    }
}

