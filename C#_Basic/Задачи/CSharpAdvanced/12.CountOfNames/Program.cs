using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOfNames
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter names, separeted by space");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> names = new List<string>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                names.Add(inputArray[i]);
            }
            names.Sort();
            int count = 1;
            for (int i = 1; i < names.Count; i++)
            {
                if (names[i] == names[i - 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", names[i - 1], count);
                    count = 1;
                }

                if (i == names.Count - 1)
                {
                    Console.WriteLine("{0} -> {1}", names[i], count);
                }

            }
        }
    }
}
