using main.MainClasses;
using main.Classes;
using main.Classes.Drives;

// -------------------------
// Lists of shop details
var motherBoardsShop = new List<MotherBoard>
{
    new MotherBoard(2609, "Intel", "USA", "MSI H510M Pro-E")
    {
        Socket = "Socket 1200",
        MemorySlots = 2,
        TypeOfRamSupport = new List<string>{"DDR4"},
        InterfaceType = new List<string>{"SATA", "SATA", "SATA", "SATA"}
    },
    new MotherBoard(1700, "Asus", "USA", "H81M-K")
    {
        Socket = "Socket 1150",
        MemorySlots = 2,
        TypeOfRamSupport = new List<string>{"DDR3"},
        InterfaceType = new List<string>{"SATA", "SATA", "SATA", "SATA"}
    },
    new MotherBoard(6800, "Gigabyte", "USA", "AORUS B550 ELITE")
    {
        Socket = "Socket AM4",
        MemorySlots = 4,
        TypeOfRamSupport = new List<string>{"DDR4"},
        InterfaceType = new List<string>{"SATA", "SATA", "SATA", "SATA", "M2", "M2"}
    }
};

var cpusShop = new List<Cpu>
{
    new Cpu(5500, "Intel", "China", "Core i5 10400F")
    {
        Cores = 6,
        Frequency = 4.3,
        Socket = "Socket 1200"
    },
    new Cpu(1700, "Intel", "USA", "Xeon e3-1270v3")
    {
        Cores = 4,
        Frequency = 3.9,
        Socket = "Socket 1150"
    },
    new Cpu(7900, "AMD", "USA", "Ryzen 7 3700X")
    {
        Cores = 8,
        Frequency = 4.4,
        Socket = "Socket AM4"
    }
};

var gpusShop = new List<Gpu>
{
    new Gpu(9500, "MSI", "USA", "GeForce GTX 1650 D6")
    {
        Memory = 4,
        Speed = 1620
    },
    new Gpu(4000, "Gigabyte", "USA", "GTX1050ti")
    {
        Memory = 4,
        Speed = 1580
    },
    new Gpu(16010, "Asus", "USA", "RTX 3060 Dual")
    {
        Memory = 12,
        Speed = 1867
    }
};

var ramsShop = new List<Ram>
{
    new Ram(900, "Kingston", "USA", "Fury DDR4-2666 8GB")
    {
        Size = 8,
        Type = "DDR4"
    },
    new Ram(1100, "GoodRam", "USA", "GoodRam DDR3-1600 8GB")
    {
        Size = 8,
        Type = "DDR3"
    },
    new Ram(1700, "Kingston", "USA", "DDR4 16GB 3200 MHZ FURY")
    {
        Size = 16,
        Type = "DDR4"
    }
};

var drivesShop = new List<Drive>
{
    new Ssd(1300, "Kingston", "USA", "HyperX SSDNow A400 480GB 2.5")
    {
        Size = 480,
        InterfaceType = "SATA",
        Speed = 475,
        Lifetime = 1_000_000
    },
    new Ssd(2200, "Samsung", "China", "EVO 860 250GB")
    {
        Size = 250,
        InterfaceType = "SATA",
        Speed = 545,
        Lifetime = 900_000
    },
    new Ssd(2200, "Samsung", "USA", "Evo 970 Plus 250GB M2")
    {
        Size = 250,
        InterfaceType = "M2",
        Speed = 3000,
        Lifetime = 3_000_000
    },
    new Hdd(1970, "Seagate", "USA", "Basic 1TB STJL1000400")
    {
        Size = 1024,
        InterfaceType = "SATA",
        Speed = 400
    },
    new Hdd(1779, "Toshiba", "USA", "Canvio Basics 1TB HDTB410EK3AA")
    {
        Size = 1024,
        InterfaceType = "SATA",
        Speed = 370
    }
};

// --------------------------



Console.Write("Choose action between computer assembly(CA) or purchase simulation(PS): ");
var actionChoose = Console.ReadLine();

switch (actionChoose)
{
    case "CA":
        var computer = new Computer();

        computer.AddDetailToComputer();
        
        break;
    
    case "PS":
        Console.Write("Enter your budget, I know .. you saved it at school lunches: ");
        var budgetUser = double.Parse(Console.ReadLine());
        Console.Write("Enter a budget of filter(max price of detail): ");
        var budgetFilter = double.Parse(Console.ReadLine());
        var cart = new Cart();
        cart.AddDetailToCart(budgetUser, budgetFilter, motherBoardsShop, cpusShop, gpusShop, ramsShop, drivesShop);
        
        break;
    
    default:
        Console.WriteLine("Entered incorrect action!");
        break;
}


