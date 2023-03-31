using Microsoft.VisualBasic;

namespace main.MainClasses;

public abstract class Detail
{
    public double Price { get; set; }
    public string? Supplier { get; set; }
    public string? Country { get; set; }
    public string? Name { get; set; }

    public Detail(double price, string supplier, string country, string name)
    {
        Price = price;
        Supplier = supplier;
        Country = country;
        Name = name;
    }

    public virtual void AddDetailByInput()
    {
        Console.Write("\nEnter a price: ");
        this.Price = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a supplier: ");
        this.Supplier = Console.ReadLine();
        Console.Write("Enter a country: ");
        this.Country = Console.ReadLine();
        Console.Write("Enter a name: ");
        this.Name = Console.ReadLine();
    }
    
    public virtual string InformationAbout()
    {
        string nameDetail = Convert.ToString(this.GetType());

        return "|================|\n" +
               $"| Name: {Name} | Cost: {Price} | Made in: {Country} | By: {Supplier} |\n" +
               $"--------{nameDetail.Split(".").Last()}--------\n";
    }
    
}