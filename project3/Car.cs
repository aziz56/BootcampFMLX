namespace ProjectTiga;

public class Car
{
	public Engine engine;
	private Lamp lamp;
	public Tire tire;
	
	public void EngineStart() 
	{
		engine.EngineRun();
	}
	public void LampCheck() 
	{
		lamp.TurnOn();
	}
}
