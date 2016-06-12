using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        char[][] matrix = new char[rows][];
        char letter= 'A';

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new char[cols];
            for (int col = 0; col < cols; col++)
            {
                matrix[row][col] = letter;
                letter++;
            }
        }

        foreach (var item in matrix)
        {
            Console.WriteLine(string.Join(" ",item));
        }
    }
}

