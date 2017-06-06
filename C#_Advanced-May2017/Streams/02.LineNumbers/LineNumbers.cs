using System;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            using (var reader = new StreamReader("../../text.txt"))
            {
                using (var writer = new StreamWriter("../../result.txt"))
                {
                    int counter = 1;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}.{line}");
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
