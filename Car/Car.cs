namespace CarLibrary;

class Car
{
    public string brand;
    public int door;
    public Engine engine;
    public Tire tire;
}
//class String
class Engine
{
    public string engineType; 
    public void EngineRun() {
        Console.WriteLine("Engine Run");
    }
}

class Tire
{
    public int tireSize;
    public void TirePump() {
        Console.WriteLine("Tire Pump");
    }
}