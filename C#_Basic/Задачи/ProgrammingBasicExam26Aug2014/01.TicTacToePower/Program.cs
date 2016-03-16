using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int[,] matrix = new int[3, 3];
        int cell = int.Parse(Console.ReadLine());
        int index = 0;
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = cell;
                cell++;
                index++;
                if (matrix[i, j] == matrix[y, x])
                {
                    
                    Console.WriteLine((long)Math.Pow(matrix[i,j], index));

                }

            }


        }

       

    }
}

