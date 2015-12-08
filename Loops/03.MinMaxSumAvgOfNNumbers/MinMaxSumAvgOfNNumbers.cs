using System;
//Write a program that reads from the console a sequence of n integer numbers and returns 
//the minimal, the maximal number, the sum and the average of all numbers 
//(displayed with 2 digits after the decimal point). The input starts by the number n
//(alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below. Examples:
class MinMaxSumAvgOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int number;
        int sum = 0;
        double avg;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
             number =int.Parse(Console.ReadLine());
            
             if (number>max)
             {
                 max = number; 
             }
             if (number<min)
             {
                 min = number;
             }
             sum = sum + number;
        }
        avg = (double)sum / n;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3}",min,max,sum,avg);
        
    }
}

