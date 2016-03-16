using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a:");
        double a = Double.Parse(Console.ReadLine());

        Console.Write("Enter b:");
        double b = Double.Parse(Console.ReadLine());

        Console.Write("Enter c:");
        double c = Double.Parse(Console.ReadLine());

        double discriminant = (b * b) - (4 * a * c);
        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (discriminant > 0)
        {
            Console.Write("x1={0};   ", (-b - Math.Sqrt(discriminant)) / (2 * a));
            Console.WriteLine("x2={0}", (-b + Math.Sqrt(discriminant)) / (2 * a));
        }
        else
        {
            Console.WriteLine("x1=x2={0}", (-b + Math.Sqrt(discriminant)) / (2 * a));
        }
    }
}
