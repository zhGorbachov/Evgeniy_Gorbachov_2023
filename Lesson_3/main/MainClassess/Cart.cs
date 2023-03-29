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
    
}
