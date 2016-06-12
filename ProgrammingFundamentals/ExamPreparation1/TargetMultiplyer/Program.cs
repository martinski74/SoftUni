using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long rows = input[0];
        long cols = input[1];
        long[,] matrix = new long[rows, cols];

        for (long i = 0; i < rows; i++)
        {
            long[] row = Console.ReadLine().Split().Select(long.Parse).ToArray();

            for (long j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        long[] targetPolong = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long rowPolong = targetPolong[0];
        long colPolong = targetPolong[1];
        long polong =matrix[rowPolong,colPolong];
        long sum = 0;

        long startRow = rowPolong - 1 >= 0 ? rowPolong - 1 : 0;
        long stratCol = colPolong - 1 >= 0 ? colPolong - 1 : 0;
        long endRow = rowPolong + 1 < rows ? rowPolong + 1 : rows - 1;
        long endCol = colPolong + 1 < cols ? colPolong + 1 : cols - 1;

        
        for (long i = startRow; i <= endRow; i++)
        {
            for (long j = stratCol; j <= endCol; j++)
            {
                sum = sum + matrix[i,j];
                matrix[i, j] = matrix[i, j] * polong;
                matrix[rowPolong, colPolong] /= polong;
            }
        }
        matrix[rowPolong, colPolong] = polong * sum;


        for (long i = 0; i < matrix.GetLength(0); i++)
        {
            for (long j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j]+ " ");
            }
            Console.WriteLine();
        }
    }
}

