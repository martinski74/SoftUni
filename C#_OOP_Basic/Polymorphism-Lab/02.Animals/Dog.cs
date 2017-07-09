
using System;

public class Dog :Animal
{
    public Dog(string name,string favouriteFood)
    {
        base.Name = name;
        base.FavouriteFood = favouriteFood;
    }
    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}

