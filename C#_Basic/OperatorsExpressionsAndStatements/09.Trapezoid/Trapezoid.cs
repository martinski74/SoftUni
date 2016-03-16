using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h
class Trapezoid
{
    static void Main()
    {
        double a = int.Parse(Console.ReadLine());
        double b = int.Parse(Console.ReadLine());
        double h = int.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine(area);
    }
}

