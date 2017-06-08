using System;

class ParseUrl
{
    static void Main()
    {
        var url = Console.ReadLine();
        var tokens = url.Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries);

        if (tokens.Length != 2 || tokens[1].IndexOf("/") < 0)
        {
            Console.WriteLine("Invalid URL");
        }
        else
        {
            var resourceIndex = tokens[1].IndexOf("/");
            var protocol = tokens[0];
            var server = tokens[1].Substring(0, resourceIndex);
            var resource = tokens[1].Substring(resourceIndex + 1);

            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resource}");
        }
    }
}