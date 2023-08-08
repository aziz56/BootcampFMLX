using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "John Doe",
            Age = 30
        };

        person.PrintInfo();
    }
}
