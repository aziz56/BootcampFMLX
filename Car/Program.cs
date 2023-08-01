using CarLibrary;

class Program {
    static void Main() {
        Car car = new Car();
        car.door = 4;
        car.brand = "Ferrari";

        Engine electric = new Engine();
        Tire inchTire = new Tire();

        car.engine = electric;
        car.tire = inchTire;
        car.engine.EngineRun();
        car.tire.TirePump();
    }
}