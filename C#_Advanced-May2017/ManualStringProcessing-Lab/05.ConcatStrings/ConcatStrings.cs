using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConcatStrings
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine();
            sb.Append(line + " ");
        }
        Console.WriteLine(sb);
    }
}

