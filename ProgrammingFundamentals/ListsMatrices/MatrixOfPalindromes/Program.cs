using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows= input[0];
        int cols = input[1];
        char a='a';
        char b= 'a';

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0}{1}{0} ",a,b);
                b++;
            }
            Console.WriteLine();
            a++;
            b = a;
        }
       
       
    }
}

