using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        List<List<int>> matrix = new List<List<int>>();

        for (int row = 0; row < rows; row++)
        {
            matrix.Add(Console.ReadLine().Split().Select(int.Parse).ToList());

        }
        CommandEngine(matrix);


    }

    static void CommandEngine(List<List<int>> matrix)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            string[] commandArgs = Console.ReadLine().Split();
            string commandName = commandArgs[0];
            string firstParameter = commandArgs[1];
            string secondParameter = commandArgs[2];

            switch (commandName)
            {
                case "swap":
                    Swap(matrix, firstParameter, secondParameter);
                    break;

                case "insert":
                    Insert(matrix,firstParameter,secondParameter);
                    break;

                case "remove":
                    Remove(matrix,firstParameter,secondParameter,int.Parse(commandArgs[3]));
                    break;
            }

        }
    }

     static void Remove(List<List<int>> matrix, string type, string position, int index)
    {
        
        if (position =="row")
        {
            switch (type)
            {
                case "even":
                    matrix[index] = matrix[index].Where(number => number % 2 != 0).ToList();
                    break;
                case "negative":
                    matrix[index] = matrix[index].Where(number => number >= 0).ToList();
                    break;
                case "odd":
                    matrix[index] = matrix[index].Where(number => number %2==0).ToList();
                    break;
                case "positive":
                    matrix[index] = matrix[index].Where(number => number < 0).ToList();
                    break;
            }
        }
        else
        {
            for (int currRow = 0; currRow < matrix.Count; currRow++)
            {
                if (index >= matrix[currRow].Count)
                {
                    continue;
                }
            }
        }
    }

    static void Insert(List<List<int>> matrix, string firstParameter, string secondParameter)
    {
        int rowIndex = int.Parse(firstParameter);
        int number = int.Parse(secondParameter);
        matrix[rowIndex].Insert(0,number);
    }

    static void Swap(List<List<int>> matrix, string firstParameter, string secondParameter)
    {
        int firstRow = int.Parse(firstParameter);
        int secondRow = int.Parse(secondParameter);
        List<int> temp = matrix[firstRow];
        matrix[firstRow] = matrix[secondRow];
        matrix[secondRow] = temp;
    }


}

