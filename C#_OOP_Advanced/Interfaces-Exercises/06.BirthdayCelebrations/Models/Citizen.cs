﻿public class Citizen:IIdentifiable,IName,IAge,IBirthday
{

    private string name;
    private int age;
    private string birthdate;
    private string id;

    public Citizen(string name, int age, string id,string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthday = birthdate;
    }
    public string Name
    {
        get => this.name;
        private set => this.name = value;
    }

    public int Age
    {
        get => this.age;
        private set => this.age = value;
    }

    public string Id
    {
        get => this.id;
        private set => this.id = value;
    }

    public string Birthday
    {
        get => this.birthdate;
        private set => this.birthdate = value;
    }
}
