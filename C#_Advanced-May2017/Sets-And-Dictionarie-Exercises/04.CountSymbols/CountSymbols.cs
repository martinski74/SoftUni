using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSymbols
{
    class CountSymbols
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dict = new SortedDictionary<char, int>();

            foreach (var ch in input)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 1);
                }
                else
                {
                    dict[ch]++;
                }
            }

            foreach (var item in dict.Keys)
            {
                Console.WriteLine($"{item}: {dict[item]} time/s");
            }

        }
    }
}
