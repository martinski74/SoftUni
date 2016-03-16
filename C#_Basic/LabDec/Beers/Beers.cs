using System;

class Beers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int beerCount = 0;
        while (input!="End")
        {
            string[] data = input.Split(' ');
            int count = int.Parse(data[0]);
            string type = data[1];

            if (type=="beers")
            {
                beerCount += count;
            }
            else if (type=="stacks")
            {
                beerCount += count * 20;
            }


            input = Console.ReadLine();
 
        }
        int totalStacks = beerCount / 20;
        int leftBeers= beerCount % 20;
        Console.WriteLine("{0} stacks + {1} beers",totalStacks,leftBeers);

    }
}

