using System;

class Program
{
    static void Main()
    {
        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double a = Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY));
        double b = Math.Sqrt((cX - bX) * (cX - bX) + (cY - bY) * (cY - bY));
        double c = Math.Sqrt((cX - aX) * (cX - aX) + (cY - aY) * (cY - aY));

        bool isTiangle = a + b > c && b + c > a && a + c > b;
        if (isTiangle)
        {
            Console.WriteLine("Yes");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("{0:F2}",area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}",a);
        }
    }
}

