using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = input[0];
        int cols = input[1];

        char[][] matrix = new char[rows][];

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        }
        int counter = 0;

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                if (matrix[row][col] == matrix[row][col + 1] && matrix[row][col] == matrix[row + 1][col] && matrix[row][col] == matrix[row + 1][col + 1])
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}

