using System;

class PlaneDown
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int border = int.Parse(Console.ReadLine());
        int planeNumb = int.Parse(Console.ReadLine());
        for (int i = 0; i < planeNumb; i++)
        {
            int planeX = int.Parse(Console.ReadLine());
            int planeY = int.Parse(Console.ReadLine());

            int palneDistanceX = planeX - x;
            int planeDistanceY = planeY - y;
            double distanceToPlane = Math.Sqrt((palneDistanceX * palneDistanceX) + (planeDistanceY * planeDistanceY));
            if (border >=distanceToPlane)
            {
                Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
            }
        }
    }
}

