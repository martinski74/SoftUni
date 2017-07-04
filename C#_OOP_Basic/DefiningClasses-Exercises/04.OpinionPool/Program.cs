using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OpinionPool
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var name = tokens[0];
                var age = int.Parse(tokens[1]);

                people.Add(new Person(name, age));

            }
            var feltered = people
                .Where(p => p.Age > 30)
                .ToList()
                .OrderBy(p => p.Name);

            foreach (var person in feltered)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
