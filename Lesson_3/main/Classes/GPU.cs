using main.MainClasses;

namespace main.Classes;

public class Gpu : Detail
{
    public int Memory { get; set; }
    public int Speed { get; set; }

    public Gpu(
        double price,
        string supplier,
        string country,
        string name) : base(price, supplier, country, name)
    {
        
    }
    
    public override void AddDetailByInput() 
    {
        base.AddDetailByInput();
        
        Console.Write("Enter count of memory: ");
        Memory = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter a speed: ");
        Speed = Convert.ToInt32(Console.ReadLine());
    }

    public override string InformationAbout()
    {
        return $"{base.InformationAbout()}" +
               $"| Memory: {Memory} |\n" +
               $"| Speed: {Speed} |";
    }
}