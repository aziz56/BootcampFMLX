//encapsulasi
public class Animali
{
    protected int age;
    public string name;
    public string getName()
    {
        return name;
    }


    public void sleep()
    {
        Console.WriteLine("sleep");
    }
    public void Makesound()
    {
        Console.WriteLine("Makesound");
    }
    protected void Eat(string food)
    {
        Console.WriteLine("Eat : " + food);
    }
}
public class Cati:Animali
{
    public void Scratch()
    {
        Console.WriteLine("Scratch");
    }
    
}
public class Birdi: Animali 
{
    public void Fly()

    {
    Console.WriteLine("Fly");

    }
}
public class Turtles:Animali 
{
    public void Swim()
    {
        Console.WriteLine("Swim");
    }
}
public class Jalan
{
    static void Main() 
    {
        
        Cat cat = new Cat();
        
        cat.Eat("fish");
        Birdi bird = new bird();
        bird.Fly();
        string? birdName =  bird.name = "aziz";

    }
}