using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = new int[8];
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        string[] binNumbers = new string[8];

        for (int i = 0; i < numbers.Length; i++)
        {
            binNumbers[i] = Convert.ToString(numbers[i], 2).PadLeft(32, '0');
        }

        for (int i = 0; i <=5; i++)
        {
            for (int j = 0; j <=29; j++)
            {
                if (binNumbers[i].Substring(j, 3) == "101" &&
                    binNumbers[i + 1].Substring(j, 3) == "010" &&
                    binNumbers[i+2].Substring(j, 3) == "101")
                {
                    count++;
                }
            }
        }
        Console.WriteLine(count);



    }
}

