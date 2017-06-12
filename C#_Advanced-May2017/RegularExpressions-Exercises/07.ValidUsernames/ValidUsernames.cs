using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class ValidUsernames
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        string pattern = "\\b[a-zA-z][\\w]{2,25}\\b";
        Regex regex = new Regex(pattern);
        List<string> validUsers = new List<string>();

        foreach (var user in input)
        {
            if (regex.IsMatch(user))
            {
                validUsers.Add(user);
            }
        }
        var maxLength = 0;
        string firstUser = "";
        string secondtUser = "";

        for (int i = 0; i < validUsers.Count - 1; i++)
        {
            int sumLenght = validUsers[i].Length + validUsers[i + 1].Length;

            if (sumLenght > maxLength)
            {
                maxLength = sumLenght;

                firstUser = validUsers[i];
                secondtUser = validUsers[i + 1];
            }
        }
        Console.WriteLine(firstUser);
        Console.WriteLine(secondtUser);
    }
}

