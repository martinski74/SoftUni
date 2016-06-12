using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

        
        while (true)
        {
            string[] input = Console.ReadLine().Split();
            if (input[0] == "end")
            {
                break;
            }
            if (input[0]=="swap")
                Swap(numbers, input);

            else if (input[0] =="multiply")
                Multiply(numbers, input);

            else if (input[0] == "decrease")
            {
                Decrease(numbers);
            }
        }
        Console.WriteLine(string.Join(", ",numbers));
    }

     static void Decrease(long[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i]--;
        }
    }

     static void Multiply(long[] numbers, string[] input)
    {
        int index1 = int.Parse(input[1]);
        int index2 = int.Parse(input[2]);

        numbers[index1] *= numbers[index2];
    }

     static void Swap(long[] numbers, string[] input)
    {
        int index1 = int.Parse(input[1]);
        int index2 = int.Parse(input[2]);

        long temp = numbers[index1];
        numbers[index1] = numbers[index2];
        numbers[index2] = temp;
    }

  
}

