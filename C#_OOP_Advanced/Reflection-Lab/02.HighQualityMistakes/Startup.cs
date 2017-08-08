using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HighQualityMistakes
{
    public class Startup
    {
        public static void Main()
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAcessModifiers(typeof(Hacker).FullName);
            Console.WriteLine(result);
        }
    }
}
