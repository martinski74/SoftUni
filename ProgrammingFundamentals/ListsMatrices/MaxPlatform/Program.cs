using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long rows = input[0];
        long cols = input[1];
        long[][] matrix = new long[rows][];
        // filling matrix
        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        }
        long maxSum = long.MinValue;
        int rowCounter = 0;
        int colCounter = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                long currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                    matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                    matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    rowCounter = row;
                    colCounter = col;

                }
            }
        }
        Console.WriteLine(maxSum);

        for (int row = rowCounter; row < rowCounter + 3; row++)
        {
            for (int col = colCounter; col < colCounter + 3; col++)
            {
                Console.Write(matrix[row][col]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

    }
}

