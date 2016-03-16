using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nSum = 0;

        while (n > 0)
        {
            nSum += n % 10;
            n /= 10;
        }
        string[] morseCode = { "-----", ".----", "..---", "...--", "....-", "....." };
        bool found = false;
        for (int i0 = 0; i0 < 6; i0++)
        {
            for (int i1 = 0; i1 < 6; i1++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    for (int i3 = 0; i3 < 6; i3++)
                    {
                        for (int i4 = 0; i4 < 6; i4++)
                        {
                            for (int i5 = 0; i5 < 6; i5++)
                            {
                                int morseProduct = i0 * i1 * i2 * i3 * i4 * i5;
                                if (morseProduct==nSum)
                                {
                                    found = true;
                                    Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|",morseCode[i0],morseCode[i1],
                                        morseCode[i2],morseCode[i3],morseCode[i4],morseCode[i5]);

                                }
                            }
                        }
                    }
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No");
        }

    }
}

