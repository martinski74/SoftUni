using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class FilterByAge
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var people = new Dictionary<string, int>();

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(new char[] { ' ',',' },StringSplitOptions.RemoveEmptyEntries);
            people.Add(tokens[0],int.Parse(tokens[1]));
        }

        var condition = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var format = Console.ReadLine();

        Func<int, bool> tester = CreateTester(condition,age);
        Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
        PrintPeople(people, tester, printer);
    }

    private static void PrintPeople(Dictionary<string, int> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
    {
        var filterdePeople = people.Where(x => tester(x.Value));

        foreach (var pair in filterdePeople)
        {
            printer(pair);
        }
    }

    private static Action<KeyValuePair<string, int>> CreatePrinter(string format)
    {
        switch (format)
        {
            case "name": return pair => Console.WriteLine($"{pair.Key}");
            case "age": return pair => Console.WriteLine($"{pair.Value}");
            case "name age": return pair => Console.WriteLine($"{pair.Key} - {pair.Value}");
            default: return null;
        }
    }

    private static Func<int, bool> CreateTester(string condition, int age)
    {
        switch (condition)
        {
            case "younger":return x => x <= age;
            case "older":return x => x >= age;
            default:return null;
        }
    }
}

