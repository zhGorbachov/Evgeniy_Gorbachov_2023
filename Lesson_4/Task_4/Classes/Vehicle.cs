using Task_4.Interfaces;

namespace Task_4.Classes;

public class Vehicle
{
    public string Car { get; }
    
    public string Motorcycle { get; }

    public Flyable Airplane { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("The engine is starting");
    }
}
