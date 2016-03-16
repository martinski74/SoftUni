using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string line1 = Console.ReadLine();
        string[] firstLine = line1.Split(' ');
        string line2 = Console.ReadLine();
        string[] secondLine = line2.Split(' ');

        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();
        List<int> joinedList = new List<int>();

        for (int i = 0; i < firstLine.Length; i++)
        {
            firstList.Add(int.Parse(firstLine[i]));
        }
        for (int i = 0; i < secondLine.Length; i++)
        {
            secondList.Add(int.Parse(secondLine[i]));
        }

        joinedList = firstList.Concat(secondList).Distinct().ToList();
        joinedList.Sort();

        foreach (var item in joinedList)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();

    }
}

