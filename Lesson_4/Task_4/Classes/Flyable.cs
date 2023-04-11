using Task_4.Interfaces;

namespace Task_4.Classes;

public class Flyable : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("It's flying?");
    }
}