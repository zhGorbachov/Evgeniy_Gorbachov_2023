using Task_4.Interfaces;

namespace Task_4.Classes;

public class Plane : Vehicle, IFlyable
{
    public override void StartEngine()
    {
        Fly();
    }

    public void Fly()
    {
        Console.WriteLine("It's flying?");
    }
}