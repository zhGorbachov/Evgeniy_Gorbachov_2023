namespace main.Classes.Drives;

public class Ssd : Drive
{
    public int Lifetime { get; set; }
    
    public Ssd(
        double price,
        string supplier,
        string country,
        string name) : base(price, supplier, country, name)
    {
        
    }
    public override void AddDetailByInput()
    {
        base.AddDetailByInput();
        
        Console.Write("Enter life time of ssd: "); 
        Lifetime = Convert.ToInt32(Console.ReadLine());
    }

    public override string InformationAbout()
    {
        return $"{base.InformationAbout()}\n" +
               $"Lifetime: {Lifetime}";
    }
}