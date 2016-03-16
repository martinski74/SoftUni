using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string guess = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        string result = "";

       
        for (int num = 1111; num <= 9999; num++)
        {
            int bull = 0;
            int cow = 0;
            bool[] isVisit = new bool[4];
            string numStr = num.ToString();
            bool hasZero = false;
            for (int i = 0; i < numStr.Length; i++)
            {
                if (numStr[i]=='0')
                {
                    hasZero = true;
                }
            }
            if (hasZero)
            {
                continue;
            }


            for (int i = 0; i < numStr.Length; i++)
            {
                if (guess[i] == numStr[i])
                {
                    bull++;
                    isVisit[i] = true;
                }
            }
            for (int i = 0; i < numStr.Length; i++)
            {
                for (int j = 0; j < numStr.Length; j++)
                {
                    if (i != j && !isVisit[i] && guess[i] == numStr[j])
                    {
                        cow++;
                        isVisit[i] = true;
                    }
                }
            }
            if (bulls == bull && cows == cow)
            {
                Console.Write(numStr+" ");
            }
        }
       
    }
}

