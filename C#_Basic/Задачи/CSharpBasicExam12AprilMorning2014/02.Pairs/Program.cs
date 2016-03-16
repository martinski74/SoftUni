using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();

        int first = int.Parse(input[0]);
        int second = int.Parse(input[1]);
        int prevValue = first + second;
        int maxDiff = 0;

        for (int i = 2; i < input.Length - 1; i += 2)
        {
            first = int.Parse(input[i]);
            second = int.Parse(input[i + 1]);
            int lastValue = first + second;
            int diff = Math.Abs(lastValue - prevValue);
            maxDiff = Math.Max(diff, maxDiff);
            prevValue = lastValue;
        }
        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value=" + prevValue);
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + maxDiff);
        }


    }
}

