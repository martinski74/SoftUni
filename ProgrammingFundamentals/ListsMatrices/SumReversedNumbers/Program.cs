using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string revesed = "";
        for (int i = numbers.Length-1; i >= 0; i--)
        {
            revesed += numbers[i];
        }
        string[] splited = revesed.Split(' ');
        int sum = 0;
        foreach (var item in splited)
        {
            sum += int.Parse(item);
        }
      
        
        Console.WriteLine(sum);
        
    }
}

