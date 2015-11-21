using System;

class SumOfFiveNumbers

{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += double.Parse(numbers[i]);
        }
        Console.WriteLine(sum);
    }
}



