using main.MainClasses;

namespace main.Classes;

public class Cpu : Detail
{
    public string? Socket { get; set; }
    public int Cores { get; set; }
    public double Frequency { get; set; }

    public Cpu(
        double price,
        string supplier,
        string country,
        string name) : base(price, supplier, country, name)
    {
        
    }
    public override void AddDetailByInput()
    {
        base.AddDetailByInput();
        
        Console.Write("Enter name of socket: ");
        Socket = Console.ReadLine();
        
        Console.Write("Enter count of cores: ");
        Cores = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter frequency of cpu(use < , > to write a number): ");
        Frequency = Convert.ToDouble(Console.ReadLine());
    }

    public override string InformationAbout()
    {
        return $"{base.InformationAbout()}" +
               $"Socket: {Socket}\n" +
               $"Cores: {Cores}\n" +
               $"Frequency: {Frequency}";
    }
}