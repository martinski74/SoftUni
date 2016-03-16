using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BaiIvan
{
    class Program
    {
        static void Main()
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());
            decimal wantedAlcohol = decimal.Parse(Console.ReadLine());
            decimal bougthAlcohol = 0;
            switch (dayOfWeek)
            {
                case 0: bougthAlcohol = money / 25M; break;
                case 1: bougthAlcohol = money / 21M; break;
                case 2: bougthAlcohol = money / 14M; break;
                case 3: bougthAlcohol = money / 17M; break;
                case 4: bougthAlcohol = money / 45M; break;
                case 5: bougthAlcohol = money / 59M; break;
                case 6: bougthAlcohol = money / 42M; break;
            }

            string status = "";
            if (bougthAlcohol > 1.5m)
            {
                status = "very drunk";
            }
            else if (bougthAlcohol <= 1.5m && bougthAlcohol >= 1.0m)
            {
                status = "drunk";
            }
            else
            {
                status = "sober";
            }
            if (wantedAlcohol < bougthAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", status, bougthAlcohol - wantedAlcohol);
            }
            else if (wantedAlcohol==bougthAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted",status);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", status, wantedAlcohol - bougthAlcohol);
            }
        }
    }
}
