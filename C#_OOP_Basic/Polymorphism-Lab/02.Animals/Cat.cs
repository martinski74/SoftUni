
using System;

public class Cat : Animal
{
    public Cat(string name, string favouriteFood)
    {
        base.Name = name;
        base.FavouriteFood = favouriteFood;
    }

    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "MEOW";
    }
}

