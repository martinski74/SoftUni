using System;
using System.Linq;

class Program
{
    static void Main()
    {
        uint r = uint.Parse(Console.ReadLine());
        uint d = uint.Parse(Console.ReadLine());
        uint e = uint.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        uint n = uint.Parse(Console.ReadLine());

        decimal rubli = (r / 100m) * 3.5m;
        decimal dolar = d * 1.5m;
        decimal euro = e * 1.95m;
        decimal bg = b / 2m;
        decimal[] all = {rubli,dolar,euro,bg,n };
        decimal max = all.Max();
        Console.WriteLine("{0:F2}", Math.Ceiling(max));
        

       // Console.WriteLine("{0:F2}",Math.Ceiling(Math.Max(rubli,(Math.Max(dolar,(Math.Max(euro,(Math.Max(bg,n)))))))));
    }
}

