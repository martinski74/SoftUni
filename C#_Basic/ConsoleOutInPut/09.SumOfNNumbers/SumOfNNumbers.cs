using System;
//Write a program that enters a number n and after that enters more n numbers and 
//calculates and prints their sum. Note that you may need to use a for-loop. 
class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;

        }
        Console.WriteLine(sum);
    }
}

