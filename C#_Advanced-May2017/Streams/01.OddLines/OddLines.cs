using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            using(var reader = new StreamReader("../../OddLines.txt"))
            {
                string line = reader.ReadLine();
                int lineNumber = 0;
                while (line != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
