using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SingleInheritance
{
    public class Program
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

        }
    }
}
