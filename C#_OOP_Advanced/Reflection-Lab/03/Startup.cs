using System;

namespace _03
{
    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.RevealPrivateMethods(typeof(Hacker).FullName);
            Console.WriteLine(result);
        }
    }
}
