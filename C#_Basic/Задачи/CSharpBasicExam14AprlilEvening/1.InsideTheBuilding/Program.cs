using System;

class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        for (int i = 0; i < 5; i++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine(InSideBuilding(x,y,h));
            
           
        }
    }

    private static string InSideBuilding(int x,int y,int size)
    {

        bool isInside = (x >= 0) && (x <= 3 * size) && (y >= 0) && (y <= size) ||
            (x >= size) && (x <= 2 * size) && (y >= size) && (y <= 4 * size);
        string result = "";
        if (isInside)
        {
            result = "inside";
        }
        else
        {
            result = "outside";
        }
        return result;
    }
}

