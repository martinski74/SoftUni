using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ParkingLot
{
    class ParkingLot
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (input != "END")
            {
                var tokens = Regex.Split(input, ", ", RegexOptions.IgnorePatternWhitespace);
                var operation = tokens[0];
                var carNumber = tokens[1];

                if (operation == "IN")
                {
                    parking.Add(carNumber);
                }
                else
                {
                    parking.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parking.Count != 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
