using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StudentsResults
{
    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|",
               "Name", "CAdv", "COOP", "AdvOOP", "Average"));
        var name = "";
        double first;
        double second;
        double tird;
        for (int i = 0; i < input; i++)
        {
            var tokens = Console.ReadLine()
                .Split(new char[] { ' ','-',','},StringSplitOptions.RemoveEmptyEntries);
             name = tokens[0];
             first = double.Parse(tokens[1]);
             second = double.Parse(tokens[2]);
             tird = double.Parse(tokens[3]);
           

            Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                name,first,second,tird,(first+second+tird)/3));
        }

    }
}

