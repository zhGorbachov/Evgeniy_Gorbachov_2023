using Task_4.Interfaces;

namespace Task_4.Classes;

public class Plane : Vehicle
{

    public override void Fly()
    {
        Console.WriteLine("Its flying!");
    }
}