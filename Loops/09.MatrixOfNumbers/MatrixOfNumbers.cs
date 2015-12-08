using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i+j+" ");
            }
            Console.WriteLine();
        }
    }
}

