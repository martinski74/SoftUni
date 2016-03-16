using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FourFactors
{
    class Program
    {
        static void Main()
        {
            double FG = double.Parse(Console.ReadLine());
            double FGA = double.Parse(Console.ReadLine());
            double TreeP = double.Parse(Console.ReadLine());
            double TOV = double.Parse(Console.ReadLine());
            double ORB = double.Parse(Console.ReadLine());
            double OppDRB = double.Parse(Console.ReadLine());
            double FT = double.Parse(Console.ReadLine());
            double FTA = double.Parse(Console.ReadLine());

            double eFg = (FG + 0.5 * TreeP) / FGA;
            double tov = TOV / (FGA + 0.44 * FTA + TOV);
            double orb = ORB / (ORB + OppDRB);
            double ft = FT / FGA;



            Console.WriteLine("eFG% {0:F3}",eFg);
            Console.WriteLine("TOV% {0:F3}",tov);
            Console.WriteLine("ORB% {0:F3}",orb);
            Console.WriteLine("FT% {0:F3}",ft);
        }
    }
}
