using ProjectTiga;

class Program 
{
	static void Main() 
	{
		Engine combustionEngine = new Engine();
		Engine electricEngine = new Engine();
		Engine dieselEngine = new Engine();
		Engine kayuhEngine = new Engine();
		
		Lamp philips = new Lamp("phillips");
		Lamp petromak = new Lamp("petromak");
		Lamp sanyo = new Lamp("sanyo");
		
		Tire woodenTire = new Tire();
		Tire rubberTire = new Tire();
		Tire offRoad = new Tire();
		
		Car teslaCar = new Car();
		teslaCar.engine = kayuhEngine;
		teslaCar.lamp = petromak;
		teslaCar.tire = offRoad;

		Car toyotaCar = new Car();
		toyotaCar.engine = combustionEngine;
		toyotaCar.lamp = philips;
		toyotaCar.tire = rubberTire;

		teslaCar.EngineStart();
		teslaCar.LampCheck();
        toyotaCar.EngineStart();
        toyotaCar.LampCheck();
        
	}
}