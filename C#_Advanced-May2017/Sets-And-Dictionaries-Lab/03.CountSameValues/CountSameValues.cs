using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountSameValues
{
    class CountSameValues
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var tokens = input.Split(' ');

            var dict = new SortedDictionary<double,int>();

            foreach (var item in tokens)
            {
                double reminder;
                if (item.Contains(","))
                {
                    reminder = double.Parse(item.Replace(",", "."));
                }
                else
                {
                    reminder = double.Parse(item);
                }



                if (!dict.ContainsKey(reminder))
                {
                    dict.Add(reminder, 1);
                }
                else
                {
                    dict[reminder]++;
                }
            }

            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }

        }
    }
}
