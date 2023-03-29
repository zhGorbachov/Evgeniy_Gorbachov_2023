using main.MainClasses;

namespace main.Classes;

public class MotherBoard : Detail
{
    public string? Socket { get; set; }
    public int MemorySlots { get; set; }
    public List<string>? InterfaceType { get; set; }
    public List<string>? TypeOfRamSupport { get; set; }

    public MotherBoard(
        double price,
        string supplier,
        string country,
        string name) : base(price, supplier, country, name)
    {
        
    }

    public override void AddDetailByInput()
    { 
        base.AddDetailByInput();
        
        Console.Write("Enter a socket type: ");
        Socket = Console.ReadLine();

        Console.Write("Enter a number of memory slots: ");
        MemorySlots = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many interface types does PC have: ");
        var countIType = Convert.ToInt32(Console.ReadLine());
        List<string> ITypes = new List<string>();
        for (int i = 0; i < countIType; i++)
        {
            Console.Write($"Enter {i + 1} interface type: ");
            string? interfaceType = Console.ReadLine();
            ITypes.Add(interfaceType);
        }

        InterfaceType = ITypes;

        Console.Write("How many ram support types does PC have: ");
        var countRType = Convert.ToInt32(Console.ReadLine());
        List<string> RTypes = new List<string>();
        for (int i = 0; i < countRType; i++)
        {
            Console.Write($"Enter {i + 1} ram support type: ");
            string? ramSupportType = Console.ReadLine();
            RTypes.Add(ramSupportType);
        }

        TypeOfRamSupport = RTypes;

    }

    public override string InformationAbout()
    {
        return $"{base.InformationAbout()}" +
               $"Socket: {Socket}\n" +
               $"Memory Slots: {MemorySlots}\n" +
               $"Interface type: {String.Join(", ", InterfaceType)}\n" +
               $"Type of ram support: {String.Join(", ", TypeOfRamSupport)}";
    }
    
}