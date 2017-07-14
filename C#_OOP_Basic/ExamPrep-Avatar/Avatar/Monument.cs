
using System.Collections.Generic;

public abstract class Monument
{
    private string name;
    

    public Monument(string name)
    {
        this.name = name;
        
    }

    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }


    public abstract int GetAffinity();

    
}

