using System;

class Program
{
    static void Main()
    {
        string initialPower = Console.ReadLine();
        initialPower = initialPower.Replace("%","");
        int power = int.Parse(initialPower);
     
        int remainingApps = 0;
       

        string command = Console.ReadLine();
        while (!command.ToLower().Equals("end"))
        {
            if (power > 15)
            {
                string[] appDetails = command.Split('_');
                int numbPart = int.Parse(appDetails[1].Replace("%",""));
                power = power - numbPart;
            }
            else
            {
                remainingApps++;
            }


            command = Console.ReadLine();
        }
        if (power <=0)
        {
            Console.WriteLine("Phone Off");
        }
        else if (power <=15)
        {
            Console.WriteLine("Connect charger -> {0}%",power);
            Console.WriteLine("Programs left -> {0}",remainingApps);
        }
        else
        {
            Console.WriteLine("Successful complete -> {0}%",power);
        }
    }
}

