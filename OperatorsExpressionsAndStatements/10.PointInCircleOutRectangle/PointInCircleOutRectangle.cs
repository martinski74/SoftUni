using System;

class PointInCircleOutRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1.5 * 1.5;
        bool isInRect = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
        if (isInCircle && !isInRect)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

