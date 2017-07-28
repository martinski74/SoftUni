﻿using System;
using System.Collections.Generic;

namespace _07.EqualityLogic
{
   public class Program
    {
       public static void Main()
        {
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>();

            var countOfPersons = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfPersons; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var age = int.Parse(tokens[1]);

                var person = new Person(name, age);
                sortedSet.Add(person);
                hashSet.Add(person);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
