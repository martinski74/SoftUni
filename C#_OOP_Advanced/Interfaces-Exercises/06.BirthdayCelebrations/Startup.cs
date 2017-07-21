using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06.BirthdayCelebrations
{
    public class Startup
    {
        public static void Main()
        {
            IList data = new List<IName>();
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(' ');
                var type = tokens[0];
                var name = tokens[1];
                switch (type)
                {
                    case "Robot": data.Add(new Robot(name, tokens[2])); break;
                    case "Pet": data.Add(new Pet(name, tokens[2])); break;
                    case "Citizen": data.Add(new Citizen(name, int.Parse(tokens[2]), tokens[3], tokens[4])); break;

                }
            }
            input = Console.ReadLine();
            var wantedItems = data.OfType<IBirthday>()
                .Where(x => x.Birthday.EndsWith(input))
                .Select(x => x.Birthday);
            Console.WriteLine(string.Join(Environment.NewLine, wantedItems));
        }
    }
}
