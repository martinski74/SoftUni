using System;
using System.Globalization;
using System.Threading;
class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        int startHours = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();

        int durationHuors = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        DateTime time = new DateTime();
        time = DateTime.Parse(startHours + ":" + startMinutes + " " + partOfDay);

        DateTime endExam = time.AddHours(durationHuors).AddMinutes(durationMinutes);
       string end = endExam.ToString("hh:mm:tt");
        Console.WriteLine(end);
    }
}
