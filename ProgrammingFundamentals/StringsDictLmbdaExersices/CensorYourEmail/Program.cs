using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string email = Console.ReadLine();
        string text = Console.ReadLine();

        string[] splited = email.Split('@');
        string userName = splited[0];
        string domain = splited[1];
        string replacement = new string('*', userName.Length) + '@' + domain;

        Console.WriteLine(text.Replace(email,replacement));

    }
}

