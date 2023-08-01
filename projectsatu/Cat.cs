
namespace CatLibrary;
public class Cat
{
    public string? name;
    public int age;

    public void MakeSound()
    {
        Console.WriteLine("MakeSound");
    
    }
    public void Eat(string food)
    {
        Console.WriteLine("Cat eat"+ food);
    }
}