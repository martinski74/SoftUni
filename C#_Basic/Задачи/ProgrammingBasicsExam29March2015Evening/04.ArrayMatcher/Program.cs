using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string firstArr = input[0];
        string secindArr = input[1];
        string command = input[2];
        List<char> newArray = new List<char>();

        if (command=="join")
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (secindArr.Contains(firstArr[i]))
                {
                    newArray.Add(firstArr[i]);
                }
            }
        }
        else if (command=="right exclude")
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (!secindArr.Contains(firstArr[i]))
                {
                    newArray.Add(firstArr[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < secindArr.Length; i++)
            {
                if (!firstArr.Contains(secindArr[i]))
                {
                    newArray.Add(secindArr[i]);
                }
            }
        }
        newArray.Sort();
        foreach (var item in newArray)
        {
            Console.Write(item);
        }
        Console.WriteLine();
      
    }
}

