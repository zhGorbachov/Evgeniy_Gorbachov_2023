using Task_4.Interfaces;

namespace Task_4.Classes;

public class Airplane : Vehicle
{
    public override void Fly()
    {
        Console.WriteLine("It's flying!");
    }
}