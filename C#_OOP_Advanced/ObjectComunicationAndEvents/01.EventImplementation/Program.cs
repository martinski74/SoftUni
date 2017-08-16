using System;

namespace _01.EventImplementation
{
    public class Program
    {
        public static void Main()
        {
            Dispatcher dispacher = new Dispatcher();
            Handler handler = new Handler();

            dispacher.NameChange += handler.OnDispatcherNameChange;

            string name = Console.ReadLine();

            while (name != "End")
            {
                dispacher.Name = name;

                name = Console.ReadLine();
            }
        }
    }
}
