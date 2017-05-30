using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftuniParty
{
    class SoftuniParty
    {
        static void Main()
        {
            var reservation = new SortedSet<string>();
            var input = Console.ReadLine();
            while (input != "PARTY")
            {
                reservation.Add(input);

                input = Console.ReadLine();
            }

            while (input != "END")
            {

                reservation.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(reservation.Count);

            foreach (var res in reservation)
            {
                Console.WriteLine(res);
            }
        }
    }
}
