using System;

class Program
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());
        bool foundSolution = false;

        for (int years = startYear; years <= endYear; years++)
        {
            for (int month = 1; month <= 12; month++)
            {
                for (int days = 1; days <= 31; days++)
                {
                    if ((month==4||month==6||month==9||month==11) && days==31)
                    {
                        continue;
                    }
                    if (DateTime.IsLeapYear(years))
                    {
                        if (month==2 && days >29)
                        {
                            continue;
                        }
                    }
                    if (!DateTime.IsLeapYear(years))
                    {
                         if (month==2 && days >28)
                        {
                            continue;
                        }
                    }
                    string currentDate = "";
                    int currenSum = 0;
                    if (days < 10)
                    {
                        currentDate += "0" + days;
                    }
                    else
                    {
                        currentDate += days.ToString();
                    }
                    if (month < 10)
                    {
                        currentDate += "-0" + month;
                    }
                    else
                    {
                        currentDate += "-" + month.ToString();
                    }
                    currentDate += "-" + years;

                    for (int i = 0; i < currentDate.Length; i++)
                    {
                        if (Char.IsDigit(currentDate[i]))
                        {
                            for (int j = i + 1; j < currentDate.Length; j++)
                            {
                                if (Char.IsDigit(currentDate[j]))
                                {
                                    currenSum += (currentDate[i] - '0') * (currentDate[j] - '0');
                                }
                            }
                        }
                    }
                    if (magicWeight == currenSum)
                    {
                        Console.WriteLine(currentDate);
                        foundSolution = true;
                    }
                }
            }
        }
        if (!foundSolution)
        {
            Console.WriteLine("No");
        }
    }
}

