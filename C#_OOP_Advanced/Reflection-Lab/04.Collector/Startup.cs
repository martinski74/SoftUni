
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Collector
{
    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters(typeof(Hacker).FullName);
            Console.WriteLine(result);
        }
    }
}
