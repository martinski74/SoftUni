using System;
using System.Reflection;

namespace _04.Telephony
{
    public class Startup
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urlAddresses = Console.ReadLine().Split();

            Smartphone phone = new Smartphone();

            foreach (string number in numbers)
            {
                Console.WriteLine(phone.Call(number));
            }

            foreach (string urlAddress in urlAddresses)
            {
                Console.WriteLine(phone.Browse(urlAddress));
            }
        }
    }
}
