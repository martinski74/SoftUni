using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int counter = 0;
        double sum = 0;
        while (input != "Quit")
        {
            string[] time = input.Split(':');
            int min = int.Parse(time[0]);
            int sec = int.Parse(time[1]);
            counter++;
            sum += min * 60 + sec;
           


            input = Console.ReadLine();
        }
        sum = sum / counter;
        if (sum < 720)
        {
            Console.WriteLine("Gold Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}",counter,Math.Ceiling((double)sum));
        }
        else if (sum >= 720 && sum <= 1440)
        {
            Console.WriteLine("Silver Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, Math.Ceiling((double)sum));
        }
        else
        {
            Console.WriteLine("Bronze Star");
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, Math.Ceiling((double)sum));
        }
    }
}

