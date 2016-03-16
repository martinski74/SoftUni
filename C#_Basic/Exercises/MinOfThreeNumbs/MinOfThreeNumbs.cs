using System;
using System.Collections.Generic;
using System.Linq;

class MinOfThreeNumbs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[]arrNumb=new int[n];
        for (int i = 0; i < n; i++)
        {
            arrNumb[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrNumb);
        foreach (var num in arrNumb.Take(3))
        {
            Console.WriteLine(num);
        }
    }
}

