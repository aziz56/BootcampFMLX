using System.Security.Cryptography.X509Certificates;
//inheritance
public class Animal
{
    public int age;
    public string name;


    public void sleep()
    {
        Console.WriteLine("sleep");
    }
    public void Makesound()
    {
        Console.WriteLine("Makesound");
    }
    public void Eat(string food)
    {
        Console.WriteLine("Eat : " + food);
    }
}
public class Cat:Animal
{
    public void Scratch()
    {
        Console.WriteLine("Scratch");
    }
    
}
public class Bird: Animal 
{
    public void Fly()

    {
    Console.WriteLine("Fly");

    }
}
public class Turtle:Animal 
{
    public void Swim()
    {
        Console.WriteLine("Swim");
    }
}
public class Program
{
    static void Main() 
    {
        Cat cat = new Cat();
        cat.Eat("fish");
    }
}



