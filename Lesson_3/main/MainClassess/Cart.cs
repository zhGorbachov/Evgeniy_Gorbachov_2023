using main.Classes;
using main.Classes.Drives;

namespace main.MainClasses;

public class Cart
{
    public List<Cpu> Cpus { get; set; }
    public List<Gpu> Gpus { get; set; }
    public List<Ram> Rams { get; set; }
    public List<MotherBoard> MotherBoards { get; set; }
    public List<Drive> Drives { get; set; }

    public void AddCpuToCart(List<Cpu> cpus)
    {
        Cpus = cpus;
    }
    public void AddGpuToCart(List<Gpu> gpus)
    {
        Gpus = gpus;
    }
    public void AddRamToCart(List<Ram> rams)
    {
        Rams = rams;
    }
    public void AddMotherboardToCart(List<MotherBoard> motherBoard)
    {
        MotherBoards = motherBoard;
    }
    public void AddDriveToCart(List<Drive> drives)
    {
        Drives = drives;
    }

    public void getInfoAboutPC()
    {
        try
        {
            if (MotherBoards != null)
            {
                foreach (var motherBoard in MotherBoards)
                {
                    Console.WriteLine(motherBoard.InformationAbout());
                }
            }

            if (Cpus != null)
            {
                Console.WriteLine(Cpus[0].InformationAbout());
            }

            if (Gpus != null)
            {
                Console.WriteLine(Gpus[0].InformationAbout());
            }

            if (Rams != null)
            {
                Console.WriteLine(Rams[0].InformationAbout());
            }

            if (Drives != null)
            {
                Console.WriteLine(Drives[0].InformationAbout());
            }
        }
        catch
        { 
            
        }
    }

    public void PrintDetailsByPrice(List<Detail> sortedResult)
    {
        foreach (var result in sortedResult)
        {
            Console.WriteLine(result.InformationAbout());
        }
    }
    
    public List<Detail> SortingByPrice(IEnumerable<Detail> listOfObjects, double budgetAll)
    {
        var sortedResult = listOfObjects.
            Where(x => x.Price <= budgetAll)
            .OrderBy(x => x.Price)
            .ToList();
        return sortedResult.ToList();
    }

    public MotherBoard AddMotheRboard(List<MotherBoard> motherBoardsShop, double budgetAll)
    {
        var motherBoard = new List<MotherBoard>();
        var sortedResult = SortingByPrice(motherBoardsShop, budgetAll);
        PrintDetailsByPrice(sortedResult);
        Console.Write("Enter a name of motherboard to add to cart: ");
        var nameOfDetail = Console.ReadLine();
        var sortedByName = motherBoardsShop.Where(x => x.Name == nameOfDetail);
        if (sortedByName.Count() != 0)
        {
            motherBoard.Add(sortedByName.Last());
            return motherBoard[0];
        }
        throw new Exception("Wrong name of detail");
    }
    
    public Cpu AddCpu(List<Cpu> cpusShop, double budgetAll)
    {
        var cpu = new List<Cpu>();
        var sortedResult = SortingByPrice(cpusShop, budgetAll);
        PrintDetailsByPrice(sortedResult);
        Console.Write("Enter a name of cpu to add to cart: ");
        var nameOfDetail = Console.ReadLine();
        var sortedByName = cpusShop.Where(x => x.Name == nameOfDetail);
        if (sortedByName.Count() != 0)
        {
            cpu.Add(sortedByName.Last());
            return cpu[0];
        }
        throw new Exception("Wrong name of detail");
    }

    public Gpu AddGpu(List<Gpu> gpusShop, double budgetAll)
    {
        var gpu = new List<Gpu>();
        var sortedResult = SortingByPrice(gpusShop, budgetAll);
        PrintDetailsByPrice(sortedResult);
        Console.Write("Enter a name of gpu to add to cart: ");
        var nameOfDetail = Console.ReadLine();
        var sortedByName = gpusShop.Where(x => x.Name == nameOfDetail);
        if (sortedByName.Count() != 0)
        {
            gpu.Add(sortedByName.Last());
            return gpu[0];
        }
        throw new Exception("Wrong name of detail");
    }
    public Ram AddRam(List<Ram> ramsShop, double budgetAll)
    {
        var ram = new List<Ram>();
        var sortedResult = SortingByPrice(ramsShop, budgetAll);
        PrintDetailsByPrice(sortedResult);
        Console.Write("Enter a name of ram to add to cart: ");
        var nameOfDetail = Console.ReadLine();
        var sortedByName = ramsShop.Where(x => x.Name == nameOfDetail);
        if (sortedByName.Count() != 0)
        {
            ram.Add(sortedByName.Last());
            return ram[0];
        }
        throw new Exception("Wrong name of detail");
    }
    public Drive AddDrive(List<Drive> drivesShop, double budgetAll)
    {
        var drive = new List<Drive>();
        var sortedResult = SortingByPrice(drivesShop, budgetAll);
        PrintDetailsByPrice(sortedResult);
        Console.Write("Enter a name of drive to add to cart: ");
        var nameOfDetail = Console.ReadLine();
        var sortedByName = drivesShop.Where(x => x.Name == nameOfDetail);
        if (sortedByName.Count() != 0)
        {
            drive.Add(sortedByName.Last());
            return drive[0];
        }
        throw new Exception("Wrong name of detail");
    }
    
    public void DeleteMotherboard()
    {
        MotherBoards.RemoveAt(MotherBoards.IndexOf(MotherBoards.Last()));
    }
    public void DeleteCpu()
    {
        Cpus.RemoveAt(Cpus.IndexOf(Cpus.Last()));
    }
    public void DeleteGpu()
    {
        Gpus.RemoveAt(Gpus.IndexOf(Gpus.Last()));
    }
    public void DeleteRam()
    {
        Rams.RemoveAt(Rams.IndexOf(Rams.Last()));
    }
    public void DeleteDrive()
    {
        Drives.RemoveAt(Drives.IndexOf(Drives.Last()));
    }

    public void AddDetailToCart(
        double budgetUser, double budgetFilter,
        List<MotherBoard> motherBoardsShop, List<Cpu> cpusShop,
        List<Gpu> gpusShop, List<Ram> ramsShop, List<Drive> drivesShop)
    {
        var computerShop = new Computer();
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
                        DeleteMotherboard();
                    }
                    else
                    {
                        selectedMotherboards.Add(AddMotheRboard(motherBoardsShop, budgetFilter));
                        AddMotherboardToCart(selectedMotherboards);
                    }

                    continue;
                case "2":
                    Console.Write("If you want to delete press - d or a - if you want to add detail: ");
                    var actionCP = Console.ReadLine();
                    if (actionCP == "d" && Cpus.Last().Name != null)
                    {
                        DeleteCpu();
                    }
                    else
                    {
                        selectedCpus.Add(AddCpu(cpusShop, budgetFilter));
                        AddCpuToCart(selectedCpus);
                    }

                    continue;
                case "3":
                    Console.Write("If you want to delete press - d or a - if you want to add detail: ");
                    var actionGP = Console.ReadLine();
                    if (actionGP == "d" && Gpus.Last().Name != null)
                    {
                        DeleteGpu();
                    }
                    else
                    {
                        selectedGpus.Add(AddGpu(gpusShop, budgetFilter));
                        AddGpuToCart(selectedGpus);
                    }

                    continue;
                case "4":
                    Console.Write("If you want to delete press - d or a - if you want to add detail: ");
                    var actionRM = Console.ReadLine();
                    if (actionRM == "d" && Rams.Last().Name != null)
                    {
                        DeleteRam();
                    }
                    else
                    {
                        selectedRams.Add(AddRam(ramsShop, budgetFilter));
                        AddRamToCart(selectedRams);
                    }

                    continue;
                case "5":
                    Console.Write("If you want to delete press - d or a - if you want to add detail: ");
                    var actionDV = Console.ReadLine();
                    if (actionDV == "d" && Drives.Last().Name != null)
                    {
                        DeleteDrive();
                    }
                    else
                    {
                        selectedDrives.Add(AddDrive(drivesShop, budgetFilter));
                        AddDriveToCart(selectedDrives);
                    }

                    continue;
                case "6":
                    getInfoAboutPC();
                    continue;
                case "7":
                    Console.WriteLine("========================\n" +
                                      "Computer will create only with last element of detail type (its for motherboard, cpu and gpu, and what about drives and rams they will all be added)!\n" +
                                      "========================");
                    try
                    {
                        computerShop.AddMotherBoard(MotherBoards.Last());
                        computerShop.AddCpu(Cpus.Last());
                        computerShop.AddGpu(Gpus.Last());
                        computerShop.AddRam(Rams);
                        computerShop.AddDrive(Drives);
                        if (budgetUser < computerShop.SumBudgetOfDetails())
                        {
                            Console.WriteLine("[FAIL] Your budget is less then budget of details in a cart!");
                            break;
                        }

                        computerShop.VerificationOfWorking();
                        computerShop.getInfoAboutPC(computerShop.MotherBoard, computerShop.Cpu, computerShop.Gpu,
                            computerShop.Rams, computerShop.Drives);
                    }
                    catch
                    {
                        Console.WriteLine("[FAIL] You probably forgot to add detail to your cart");
                    }

                    break;
            }

            break;
        }
    }
}
