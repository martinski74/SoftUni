namespace _01.ShcoolCompetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShcoolCompetition
    {
        public static void Main()
        {
            var categories = new Dictionary<string, HashSet<string>>();
            var results = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                var parts = input.Split(' ');
                var player = parts[0];
                var category = parts[1];
                var result = int.Parse(parts[2]);

                if (!categories.ContainsKey(player))
                {
                    categories.Add(player,  new HashSet<string>());
                }
                categories[player].Add(category);

                if (!results.ContainsKey(player))
                {
                    results.Add(player, result);
                }
                else
                {
                    results[player] += result;
                }
                
            }

            var ordered = results
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key);

            foreach (var player in ordered)
            {
                var orderedCategories = categories[player.Key]
                    .OrderBy(c => c);
                string listCategories = string.Join(", ", orderedCategories);
                Console.WriteLine($"{player.Key}: {player.Value} [{listCategories}]");
            }
        }
    }
}
