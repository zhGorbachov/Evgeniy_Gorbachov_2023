using main.MainClasses;

namespace main.Classes;

public class Ram : Detail
{
    public string? Type { get; set; }
    public int Size { get; set; }
    
    public Ram(
        double price,
        string supplier,
        string country,
        string name) : base(price, supplier, country, name)
    {
        
    }
    public override void AddDetailByInput()
    {
        base.AddDetailByInput();
        
        Console.Write("Enter type of ram: "); 
        Type = Console.ReadLine();
        
        Console.Write("Enter a size of ram: "); 
        Size = Convert.ToInt32(Console.ReadLine());
    }
    

    public override string InformationAbout()
    {
        return $"{base.InformationAbout()}" +
               $"Type: {Type}\n" +
               $"Size: {Size}";
    }
}