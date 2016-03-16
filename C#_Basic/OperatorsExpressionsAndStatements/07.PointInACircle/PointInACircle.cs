using System;
//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInside = (x * x) + (y * y) <= 2 * 2;
        Console.WriteLine(isInside);
    }
}

