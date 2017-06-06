using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main()
        {
            var words = new Dictionary<string, int>();

            using (var wordReader = new StreamReader("../../words.txt"))
            {
                var line = wordReader.ReadLine();

                while (line != null)
                {
                    var wordTokens = Regex
                            .Split(line.ToLower(), @"\W+");


                    foreach (var word in wordTokens)
                    {
                        words[word] = 0;
                    }
                    line = wordReader.ReadLine();
                }

                using (var textReader = new StreamReader("../../text.txt"))
                {
                  line = textReader.ReadLine();

                    while (line != null)
                    {
                        var wordTokens = Regex
                            .Split(line.ToLower(), @"\W+");



                        foreach (var word in wordTokens)
                        {
                            if (words.ContainsKey(word))
                            {
                                words[word]++;
                            }
                        }
                        line = textReader.ReadLine();
                    }
                    
                }

                using (var writer = new StreamWriter("../../result.txt"))
                {
                    var orderedWords = words.OrderByDescending(x => x.Value);

                    foreach (var pair in orderedWords)
                    {
                        writer.WriteLine($"{pair.Key} - {pair.Value}");
                    }
                }
            }
        }
    }
}
