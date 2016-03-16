using System;

class Program
{
    static void Main()
    {

        uint b = uint.Parse(Console.ReadLine());
        uint r = uint.Parse(Console.ReadLine());
        uint c = uint.Parse(Console.ReadLine());
        uint t = uint.Parse(Console.ReadLine());
        uint o = uint.Parse(Console.ReadLine());
        decimal n = decimal.Parse(Console.ReadLine());
        decimal nikiSalary = decimal.Parse(Console.ReadLine());
        nikiSalary *= n;
        decimal s = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());

        decimal buildersSalary = 1500.04m * b;
        decimal receptionistsSalary = 2102.10m * r;
        decimal chambermaidsSalary = 1465.46m * c;
        decimal techniciansSalary = 2053.33m * t;
        decimal othersSalary = 3010.98m * o;

        decimal totalExpences = buildersSalary + receptionistsSalary +
            chambermaidsSalary + techniciansSalary +
            othersSalary + nikiSalary + s;

        Console.WriteLine("The amount is: {0:f2} lv.", totalExpences);
        Console.WriteLine("{0} \\ {1}: {2:F2} lv.",
            totalExpences <= m ? "YES" : "NO",
            totalExpences<= m ? "Left":"Need more",
            Math.Abs(m-totalExpences));




    }
}

