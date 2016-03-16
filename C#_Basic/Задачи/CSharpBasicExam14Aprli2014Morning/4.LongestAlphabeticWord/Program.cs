using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] word = Console.ReadLine().ToCharArray();
        int n = int.Parse(Console.ReadLine());

        char[,] matrix = new char[n, n];
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = word[index];
                index++;
                if (index == word.Length)
                {
                    index = 0;
                }
                //Console.Write(matrix[i, j]);
            }
            //Console.WriteLine();
        }

    }
}

