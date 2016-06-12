using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        var matrix= new string[rows][];

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().Split(' ');
        }

        for (int col = 0; col < cols; col++)
        {
            for (int row = rows -1; row >= 0; row--)
            {
                Console.Write(matrix[row][col]+" ");
            }
            Console.WriteLine();
        }
    }
}

