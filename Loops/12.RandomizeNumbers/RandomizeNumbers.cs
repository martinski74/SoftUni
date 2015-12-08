using System;

class RandomizeNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(rnd.Next(1, n) + " ");
        }
        Console.WriteLine();
    }
}

