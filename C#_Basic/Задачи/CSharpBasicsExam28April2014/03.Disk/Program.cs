using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int centerX = n / 2;
        int centerY = n / 2;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int distY = centerY - i;
                int distX = centerX - j;
                double distance = Math.Sqrt(distX * distX + distY * distY);
                if (distance <= r)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}

