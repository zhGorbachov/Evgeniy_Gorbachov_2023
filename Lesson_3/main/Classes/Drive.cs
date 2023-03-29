using main.MainClasses;

namespace main.Classes;

public abstract class Drive : Detail
{
    public int Size { get; set; }
    public int Speed { get; set; }
    public string? InterfaceType { get; set; }

    protected Drive(
        double price,
        string supplier,
        string country,
        string name) : base(price, supplier, country, name)
    {
        
    }
    public override void AddDetailByInput()
    {
        base.AddDetailByInput();
        
        Console.Write("Enter size of disk: "); 
        Size = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter speed of disk: "); 
        Speed = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter type of interface: "); 
        InterfaceType = Console.ReadLine();
    }

    public override string InformationAbout()
    {
        return $"{base.InformationAbout()}" +
               $"Size: {Size}\n" +
               $"Speed: {Speed}\n" +
               $"Interface type: {InterfaceType}";
    }
}