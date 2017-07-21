public class Pet :IName,IBirthday
{
    private string name;
    private string birthday;

    public Pet(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }

    public string Name
    {
        get => this.name;
        private set => this.name = value;

    }

    public string Birthday
    {
        get => this.birthday;
        private set => this.birthday = value;
    }
}

