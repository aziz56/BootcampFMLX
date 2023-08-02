class Program 
{
	static void Main() 
	{
		Animal animal= new Animal();
		Cat cat = new Cat();
		Dog dog = new Dog();
		Ant ant= new Ant();

		animal.MakeSound();
		cat.MakeSound();
		dog.MakeSound();
		ant.MakeSound();

		//Overload
		animal.Eat();
		animal.Eat("meat");
		animal.Eat("fruit", 3);
	}
}

class Animal 
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Sounding");
	}
	public void Eat() 
	{
		Console.WriteLine("Eat default");
	}
	public void Eat(string food)
	{
		Console.WriteLine("Eat : " + food);
	}
	public void Eat(string food, int x) 
	{
		Console.WriteLine($"Eat {food} for {x} times");
	}
}
class Cat : Animal 
{
	public override void MakeSound() 
	{
		Console.WriteLine("Meow");
	}
}
class Dog : Animal 
{
	public override void MakeSound() 
	{
		Console.WriteLine("Bark");
	}
}
class Ant : Animal 
{
}