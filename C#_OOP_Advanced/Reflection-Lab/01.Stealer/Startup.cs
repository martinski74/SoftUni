using System;
using System.Collections.Generic;

namespace _01.Stealer
{
    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.StealFieldInfo(typeof(Hacker).FullName, "username", "password");
            Console.WriteLine(result);
        }
    }
}
