using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            //Primary diagonal:
            int primarySum = 0;

            for (int row = 0; row < n; row++)
            {
                primarySum += matrix[row][row];
            }

            //Secondary diagonal:
            int secondarySum = 0;

            for (int row = 0, col = n - 1; row < n; row++, col--)
            {
                secondarySum += matrix[row][col];
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
