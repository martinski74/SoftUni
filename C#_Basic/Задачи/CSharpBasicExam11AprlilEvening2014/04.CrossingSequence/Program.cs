using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int f1 = int.Parse(Console.ReadLine());
        int f2 = int.Parse(Console.ReadLine());
        int f3 = int.Parse(Console.ReadLine());

        int initialNum = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int end = 1000000;
        bool[] isTribonaci = new bool[1000000 + 1];
        isTribonaci[f1] = true;
        isTribonaci[f2] = true;
        isTribonaci[f3] = true;
        int next = 0;
        int currentNum = 0;

        while (true)
        {
            currentNum = f1 + f2 + f3;
            f1 = f2;
            f2 = f3;
            f3 = currentNum;
            if (currentNum > end)
            {
                break;
            }
            isTribonaci[currentNum] = true;
        }
        bool isCrosed = false;
        int count = 1;
        
        while (initialNum <= 1000000)
        {
            if (isTribonaci[initialNum] == true)
            {
                isCrosed = true;
                Console.WriteLine(initialNum);
                break;
            }
            
            initialNum+=step*(count/2);
            count++;
               
        }
        if (!isCrosed)
        {
            Console.WriteLine("No");
            
        }


    }
}

