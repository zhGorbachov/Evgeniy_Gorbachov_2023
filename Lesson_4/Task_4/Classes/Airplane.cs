using Task_4.Interfaces;

namespace Task_4.Classes;

public class Airplane : Vehicle, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("It's flying!");
    }
}