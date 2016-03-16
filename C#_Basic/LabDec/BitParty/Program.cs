using System;

class BitParty
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int [] numbers= new int[count];
        for (int i = 0; i < count; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        string command = Console.ReadLine();
        while (command!="party over")
        {
            string[] data = command.Split();
            string firstCom = data[0];
            int position = int.Parse(data[1]);

            for (int i = 0; i < count; i++)
            {
               

                switch (firstCom)
                {
                    case "-1": numbers[i] = numbers[i] ^ (1 << position);
                        break;

                    case "0": numbers[i] = numbers[i] & ~(1 << position);
                        break;

                    case "1": numbers[i] = numbers[i] | (1 << position);
                        break;
                }
            }


            command = Console.ReadLine();
        }

        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
