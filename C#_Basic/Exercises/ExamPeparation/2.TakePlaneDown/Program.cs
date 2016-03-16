using System;

class Program
{
    static void Main()
    {
        int centerX = int.Parse(Console.ReadLine());
        int centerY = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());
        int numbOfPlanes = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbOfPlanes; i++)
        {
            int planeX = int.Parse(Console.ReadLine());
            int planeY = int.Parse(Console.ReadLine());

            int distX =  planeX - centerX;
            int distY = planeY - centerY;
            bool isInside = Math.Sqrt((distX * distX) + (distY * distY)) <= radius;
            if (isInside)
            {
                Console.WriteLine("You destroyed a plane at [{0},{1}]",planeX,planeY);
            }
        }
    }
}

