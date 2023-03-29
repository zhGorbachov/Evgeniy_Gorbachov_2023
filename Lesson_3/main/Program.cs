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

        computer.addDetailToComputer();

        computer.VerificationOfWorking();
        break;
    
    case "PS":
        Console.Write("Enter your budget, I know .. you saved it at school lunches: ");
        var budgetUser = double.Parse(Console.ReadLine());
        var budgetFilter = budgetUser;
        
        var computerShop = new Computer();
        var cart = new Cart();
        var selectedMotherboards = new List<MotherBoard>();
        var selectedCpus = new List<Cpu>();
        var selectedGpus = new List<Gpu>();
        var selectedRams = new List<Ram>();
        var selectedDrives = new List<Drive>();

        while (true)
        {
            computerShop.getInfo("cart");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    
                    Console.Write("If you want to delete press - d or a - if you want to add detail: ");
                    var actionMB = Console.ReadLine();
                    if (actionMB == "d" && selectedMotherboards[0] != null) 
                    { 
                        cart.DeleteMotherboard();
                    }
                    else
                    {
                        selectedMotherboards.Add(cart.AddMotheRboard(motherBoardsShop, budgetFilter));
                        cart.AddMotherboardToCart(selectedMotherboards);
                    }
                    continue;
                case "2":
                    Console.Write("If you want to delete press - d or a - if you want to add detail: ");
                    var actionCP = Console.ReadLine();
                    if (actionCP== "d" && cart.Cpus.Last().Name != null)
                    {
                        cart.DeleteCpu();
                    }
                    else
                    {
                        selectedCpus.Add(cart.AddCpu(cpusShop, budgetFilter));
                        cart.AddCpuToCart(selectedCpus);
                    }
                    continue;
                case "3":
                    Console.Write("If you want to delete press - d or a - if you want to add detail: ");
                    var actionGP = Console.ReadLine();
                    if (actionGP== "d" && cart.Gpus.Last().Name != null)
                    {
                        cart.DeleteGpu();
                    }
                    else
                    {
                        selectedGpus.Add(cart.AddGpu(gpusShop, budgetFilter));
                        cart.AddGpuToCart(selectedGpus);
                    }
                    continue;
                case "4":
                    Console.Write("If you want to delete press - d or a - if you want to add detail: ");
                    var actionRM = Console.ReadLine();
                    if (actionRM== "d" && cart.Rams.Last().Name != null)
                    {
                        cart.DeleteRam();
                    }
                    else
                    {
                        selectedRams.Add(cart.AddRam(ramsShop, budgetFilter));
                        cart.AddRamToCart(selectedRams);
                    }
                    continue;
                case "5":
                    Console.Write("If you want to delete press - d or a - if you want to add detail: ");
                    var actionDV = Console.ReadLine();
                    if (actionDV== "d" && cart.Drives.Last().Name != null)
                    {
                        cart.DeleteDrive();
                    }
                    else
                    {
                        selectedDrives.Add(cart.AddDrive(drivesShop, budgetFilter));
                        cart.AddDriveToCart(selectedDrives);
                    }
                    continue;
                case "6":
                    cart.getInfoAboutPC();
                    continue;
                case "7":
                    Console.WriteLine("========================\n" +
                                      "Computer will create only with last element of detail type (its for motherboard, cpu and gpu, and what about drives and rams they will all be added)!\n" +
                                      "========================");
                    try
                    {
                        computerShop.AddMotherBoard(cart.MotherBoards.Last());
                        computerShop.AddCpu(cart.Cpus.Last());
                        computerShop.AddGpu(cart.Gpus.Last());
                        computerShop.AddRam(cart.Rams);
                        computerShop.AddDrive(cart.Drives);
                        if (budgetUser < computerShop.SumBudgetOfDetails())
                        {
                            Console.WriteLine("[FAIL] Your budget is less then budget of details in a cart!");
                            break;
                        }

                        computerShop.VerificationOfWorking();
                        computerShop.getInfoAboutPC(computerShop.MotherBoard, computerShop.Cpu, computerShop.Gpu, computerShop.Rams, computerShop.Drives);
                    }
                    catch
                    {
                        Console.WriteLine("[FAIL] You probably forgot to add detail to your cart");
                    }
                    
                    break;
            }
            
            break;
        }
        
        break;
    
    default:
        Console.WriteLine("Entered incorrect action!");
        break;
}


