using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        int perfGCounter = 0;
        while (input != "Enough dates!")
        {
            string[] line = input.Split('\\');
            string day = line[0];
            string phone = line[1];
            string bra = line[2];

            string name = line[3];
            int num = 0;
            int result = 0;
            switch (day)    // set days sum
            {
                case "Monday": num = 1; break;
                case "Tuesday ": num = 2; break;
                case "Wednesday ": num = 3; break;
                case "Thursday ": num = 4; break;
                case "Friday ": num = 5; break;
                case "Saturday ": num = 6; break;
                case "Sunday ": num = 7; break;
            }
            result += num;
            int numbSum = 0;
            foreach (var digit in phone)
            {
                numbSum += int.Parse(digit.ToString());
            }
            result += numbSum;
            // set bra numbers sum
            int braSize = 0;
            char braLetter = bra[bra.Length - 1];
            if (bra.Length == 3)
            {
                braSize = int.Parse(bra.Substring(0, 2));
            }
            else
            {
                braSize = int.Parse(bra.Substring(0, 3));

            }
            result += braSize * braLetter;
            //set name first letter and sum

            char firstLetter = name[0];
            int lenght = firstLetter * name.Length;
            result = result - lenght;
            if (result >= 6000)
            {
                Console.WriteLine("{0} is perfect for you.",name);
                perfGCounter++;
            }
            else
            {
                Console.WriteLine("Keep searching, {0} is not for you.",name);
            }

            input = Console.ReadLine();
        }
        Console.WriteLine(perfGCounter);
    }
}

