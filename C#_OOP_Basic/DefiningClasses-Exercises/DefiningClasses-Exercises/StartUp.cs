using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses_Exercises
{
    public class StartUp
    {
        public static void Main()
        {
            var pesho = new Person() { name = "Pesho", age = 20 };
            var gosho = new Person() { name = "Gosho", age = 18 };
            var stamat = new Person() { name = "Stamat", age = 43 };

            var personType = typeof(Person);
            var fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }
}
