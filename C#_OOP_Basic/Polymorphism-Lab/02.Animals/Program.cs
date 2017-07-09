using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Animals
{
    public class Program
    {
        public static void Main()
        {
            Animal cat = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainMyself());
            Console.WriteLine(dog.ExplainMyself());

        }
    }
}
