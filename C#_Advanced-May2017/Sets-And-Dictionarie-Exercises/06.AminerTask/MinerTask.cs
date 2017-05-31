using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinerTask
{
    class Program
    {
        static void Main()
        {
            string input = "";

            Dictionary<string, double> minerDict = new Dictionary<string, double>();

            while ((input = Console.ReadLine()) != "stop")
            {
                if (!minerDict.ContainsKey(input))
                {
                    minerDict.Add(input, double.Parse(Console.ReadLine()));
                }
                else
                {
                    minerDict[input] += double.Parse(Console.ReadLine());
                }
            }

            foreach (var item in minerDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
