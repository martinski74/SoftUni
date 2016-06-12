using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(new[] { ' ', '.', ',', '?', '!', ';' }
            , StringSplitOptions.RemoveEmptyEntries);
        string result = "";
        foreach (var word in text)
        {
            string first = word.Substring(0,1).ToUpper();
            string rest = word.Substring(1,word.Length-1);
            result += first + rest+" ";
        }
        Console.WriteLine(result);
    }
}

