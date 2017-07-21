using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FoodShortage
{
    public class Startup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var buyers = new Dictionary<string, IBuyer>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();

                if (tokens.Length > 3)
                {
                    var name = tokens[0];
                    var age = int.Parse(tokens[1]);
                    var id = tokens[2];
                    var birthdate = tokens[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    buyers[name] = citizen;

                }
                else
                {
                    var name = tokens[0];
                    var age = int.Parse(tokens[1]);
                    var group = tokens[2];

                    Rabel rebel = new Rabel(name,age,group);
                    buyers[name] = rebel;

                }
            }

            var buyerName = Console.ReadLine();
            while (buyerName != "End")
            {
                if (buyers.ContainsKey(buyerName))
                {
                    buyers[buyerName].BuyFood();
                }
                buyerName = Console.ReadLine();
            }

            Console.WriteLine(buyers.Values.Sum(b => b.Food));
        }
    }
}
