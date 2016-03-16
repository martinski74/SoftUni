using System;

class RandomNumberInGivenRange
{
    static void Main()
    {

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        if (min < max)
        {
            Random rnd = new Random();

            for (int i = 0; i <= n; i++)
            {
                Console.Write(rnd.Next(min, max) + " ");
            }
            Console.WriteLine();
            

        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

