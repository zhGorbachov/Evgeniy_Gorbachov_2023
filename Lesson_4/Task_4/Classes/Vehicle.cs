using Task_4.Interfaces;

namespace Task_4.Classes;

public class Vehicle : IFlyable
{
    public virtual void Fly()
    {
        Console.WriteLine("It's flying?");
    }
    public virtual void StartEngine()
    {
        Console.WriteLine("The engine is starting");
    }
}
