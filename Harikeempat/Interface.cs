using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Harikeempat;
public interface IKeyboard
{
    public void Nyala();

}
public class KeyboardMek: IKeyboard
{
    public void Nyala()
    {
        Console.WriteLine("Klotak2");
    }
}
public class KeyboardSmooth : IKeyboard
    {
        public void Nyala()
        {
             Console.WriteLine("gadabunyi");
        }
    }


public interface IMouse
{
public void Nyala();
}

public class MouseBall : IMouse
{
    public void Nyala()
    {
        Console.WriteLine("Mouseball Nyala");
    }
    
}
    public class MouseInfrared : IMouse
    {
    public void Nyala()
    {
        Console.WriteLine("Mouseinfra Nyala");
    }
}
    public class MouseKabel : IMouse
    {
        public void Nyala()
        {
            Console.WriteLine("Mousekabelnyala");
        }
    }
    public class AlatKomp
    {
        public IMouse mouse;
        public IKeyboard keyboard;
        public AlatKomp(IMouse mouse, IKeyboard keyboard )
        {
            this.mouse = mouse;
            this.keyboard = keyboard;
        }
        public void Hidup()
        {
            mouse.Nyala();
            keyboard.Nyala();
        }
    }

class Program 
{
public static void Main()
{
    KeyboardMek keyboardMek = new();
    KeyboardSmooth keyboardSmooth = new();
    MouseBall mouseBall = new();
    MouseInfrared mouseInfrared = new();

    AlatKomp alatKomp = new AlatKomp(mouseBall, keyboardMek );
    alatKomp.Hidup();

}
}