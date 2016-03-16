using System;

class Program
{
    static void Main()
    {

        int arrayLenght = int.Parse(Console.ReadLine());
        string[] words = new string[arrayLenght];

        for (int i = 0; i < words.Length; i++)
        {
            string arrayElement = Console.ReadLine();
            words[i] = arrayElement;
        }

        int startIndex = 0;
        int lenghtCount = 1;
        int currentCount = 1;

        for (int i = 0; i < words.Length - 1; i++) //could start on index 1 and check current with previous elements
        {
            if (words[i] == words[i + 1])
            {
                currentCount++;

                if (currentCount > lenghtCount)
                {
                    lenghtCount = currentCount;
                    startIndex = (i + 1) - (lenghtCount - 1);
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        Console.WriteLine(lenghtCount);
        for (int i = 0; i < lenghtCount; i++)
        {
            Console.WriteLine(words[startIndex + i]);
        }
       
    }
}

