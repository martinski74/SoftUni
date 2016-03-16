using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int perfectGirl = 0;

        while (input != "Enough dates!")
        {
            string[] inputDetails = input.Split('\\');
            string weeks = inputDetails[0];
            string phone = inputDetails[1];
            string bra = inputDetails[2];
            string name = inputDetails[3];

            int numberOfWeek = 0;
            int result = 0;
            switch (weeks)
            {
                case "Monday": numberOfWeek = 1; break;
                case "Tuesday": numberOfWeek = 2; break;
                case "Wednesday": numberOfWeek = 3; break;
                case "Thursday": numberOfWeek = 4; break;
                case "Friday": numberOfWeek = 5; break;
                case "Saturday": numberOfWeek = 6; break;
                case "Sunday": numberOfWeek = 7; break;
            }
            result += numberOfWeek;

            for (int i = 0; i < phone.Length; i++)
            {
                result += int.Parse(phone[i].ToString());
            }

            int braSise = 0;
            char braLetter = bra[bra.Length - 1];

            if (bra.Length == 3)
            {
                braSise = int.Parse(bra.Substring(0, 2));
            }
            else
            {
                braSise = int.Parse(bra.Substring(0, 3));
            }
            result += (braSise * braLetter);

            char firstLeter = name[0];
            result = result - (firstLeter * name.Length);

            if (result >= 6000)
            {
                Console.WriteLine("{0} is perfect for you.", name);
                perfectGirl++;
            }
            else
            {
                Console.WriteLine("Keep searching, {0} is not for you.", name);
            }


            input = Console.ReadLine();
        }
        Console.WriteLine(perfectGirl);
    }
}

