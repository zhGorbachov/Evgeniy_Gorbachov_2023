namespace main.Classes.Drives;

public class Hdd : Drive
{
    public Hdd(
        double price,
        string supplier,
        string country,
        string name) : base(price, supplier, country, name)
    {
        
    }
    public override void AddDetailByInput()
    {
        base.AddDetailByInput();
    }

    public override string InformationAbout()
    {
        return base.InformationAbout();
    }
}