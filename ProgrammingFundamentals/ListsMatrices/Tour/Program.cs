using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[][]matrix= new int[size][];

        for (int i = 0; i < size; i++)
        {
            matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        int[] cityes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int distance = 0;
        int currentCity = 0;

        for (int i = 0; i < cityes.Length; i++)
        {
            int destination = cityes[i];
            distance += matrix[currentCity][destination];
            currentCity = destination;
        }
        Console.WriteLine(distance);

    }
}

