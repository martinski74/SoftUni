using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int width = size;
        int height = size + size / 2;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if ((i + j) % 3 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

