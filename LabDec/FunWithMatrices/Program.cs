using System;

class Program
{
    static void Main()
    {
        double start = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        double[,] matrix = new double[4,4];
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                matrix[row, col] = start;
                start += step;
            }
        }

        string[] command = Console.ReadLine().Split();

        while (command[0] != "Game")
        {
            int row = int.Parse(command[0]);
            int col = int.Parse(command[1]);
            string oreder = command[2];
            double num = double.Parse(command[3]);

            switch (oreder)
            {
                case "multiply": matrix[row, col] *= num;
                    break;

                case "sum": matrix[row, col] += num;
                    break;

                case "power": matrix[row, col] = Math.Pow(matrix[row, col],num);
                    break;
            }



            command = Console.ReadLine().Split();
        }

        double maxSum = double.MinValue;
        int index = 0;
        string maxType = "ROW";
        for (int row = 0; row < 4; row++)
        {
            double sum = matrix[row, 0] + matrix[row, 1] + matrix[row, 2] + matrix[row, 3];
            if (sum > maxSum)
            {
                maxSum = sum;
                index = row;
            }
        }
        for (int col = 0; col < 4; col++)
        {
            double sum = matrix[0, col] + matrix[1, col] + matrix[2, col] + matrix[3, col];
            if (sum > maxSum)
            {
                maxSum = sum;
                index = col;
                maxType = "COLUMN";
            }
        }

        double leftDiagon= matrix[0,0]+matrix[1,1]+matrix[2,2]+matrix[3,3];
        if (leftDiagon > maxSum)
        {
            maxSum = leftDiagon;
            maxType = "LEFT-DIAGONAL";
        }
        double rightDiagon = matrix[3, 0] + matrix[2, 1] + matrix[1, 2] + matrix[0, 3];
        if (rightDiagon > maxSum)
        {
            maxSum = rightDiagon;
            maxType = "RIGHT-DIAGONAL";
        }

        if (maxType=="ROW"|| maxType=="COLUMN")
        {
            Console.WriteLine("{0}[{1}] = {2:f2}",maxType,index,maxSum);
        }
        else
        {
            Console.WriteLine("{0} = {1:f2}",maxType,maxSum);
        }
    }
}                   

