using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.OldestFamilyMember
{
    public class StartUp
    {
        public static void Main()
        {
            var numbersOfPeople = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < numbersOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                var person = new Person(name,age);
                family.AddMember(person);
            }

            var oldestPerson = family.GetOldestMembers();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
