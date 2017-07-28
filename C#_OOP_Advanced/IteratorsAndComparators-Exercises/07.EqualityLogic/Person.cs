using System;
using System.Collections.Generic;

public class Person : IComparable<Person>, IComparer<Person>
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person other)
    {
        return this.Compare(this, other);
    }

    public int Compare(Person first, Person second)
    {
        if (first.Name.CompareTo(second.Name) != 0)
        {
            return first.Name.CompareTo(second.Name);
        }

        return first.Age.CompareTo(second.Age);
    }

    public override bool Equals(object obj)
    {
        var item = obj as Person;

        if (item == null)
        {
            return false;
        }

        return this.Name.Equals(item.Name) && this.Age.Equals(item.Age);
    }

    public override int GetHashCode()
    {
        return this.Name.Length * this.Age;
    }
}
