using main.Classes;
using main.Classes.Drives;

namespace main.MainClasses;

public class Computer
{
    public Cpu Cpu { get; set; }
    public Gpu Gpu { get; set; }
    public List<Ram> Rams { get; set; }
    public MotherBoard MotherBoard { get; set; }
    public List<Drive> Drives { get; set; }
    
    public void AddMotherBoard(MotherBoard motherBoard)
    {
        MotherBoard = motherBoard;
    }

    public void AddCpu(Cpu cpu)
    {
        Cpu = cpu;
    }
    
    public void AddGpu(Gpu gpu)
    {
        Gpu = gpu;
    }
    
    public void AddDrive(List<Drive> drives)
    {
        Drives = drives;
    }
    
    public void AddRam(List<Ram> rams)
    {
        Rams = rams;
    }
    
    public bool CorrectCpu()
    {
        if (this.MotherBoard.Socket != this.Cpu.Socket)
        {
            Console.WriteLine($"Computer will not work, as socket of motherboard: {this.MotherBoard.Socket} doesnt have {this.Cpu.Socket}");
            return false;
        }

        return true;
    }

    public bool CorrectRam()
    {
        var selected = 
            from x in this.MotherBoard.TypeOfRamSupport 
            from y in this.Rams
            where x == y.Type 
            select y;
        if (this.MotherBoard.MemorySlots < this.Rams.Count && selected.Count() != this.Rams.Count)
        {
            Console.WriteLine($"Computer will not work, as memory slots of motherboard = {this.MotherBoard.MemorySlots} and it less then ram counts = {this.Rams.Count}");
            return false;
        }
        
        return true;
    }
    
    public bool CorrectDrives()
    {
        if (this.MotherBoard.InterfaceType.Count < this.Drives.Count)
        {
            Console.WriteLine(
                $"Computer will not work, as motherboard doesnt have enough inputs: {this.MotherBoard.InterfaceType.Count} < {this.Drives.Count}.");
            return false;
        }
        else
        {
            Dictionary<string, bool> dictionaryDrives = new Dictionary<string, bool>();

            foreach (var drive in Drives)
            {
                if (dictionaryDrives.Keys.Contains(drive.InterfaceType) && dictionaryDrives.Values.Contains(true))
                {
                    continue;
                }
                else if (this.MotherBoard.InterfaceType.Contains(drive.InterfaceType))
                {
                    dictionaryDrives.Add(drive.InterfaceType, true);
                }
            }
            if (dictionaryDrives.Count != Drives.Count)
            {
                Console.WriteLine($"Computer will not work, as motherboard does not have the interface type that was given from the disk: {String.Join(", ", dictionaryDrives.Keys)}.");
                return false;
            }

            return true;
        }
    }

    public void getInfo(string name)
    {
        Console.WriteLine($"|================|\n" +
                          $"1)Add motherboard to {name}\n" +
                          $"2)Add cpu to {name}\n" +
                          $"3)Add gpu to {name}\n" +
                          $"4)Add ram to {name}\n" +
                          $"5)Add drive to {name}\n" +
                          $"6)Info about {name}\n" +
                          "7)Exit\n" +
                          "|================|");
    }

    public void getInfoAboutPC(MotherBoard motherBoard, Cpu cpu, Gpu gpu, List<Ram> rams, List<Drive> drives)
    {
        if (motherBoard != null)
        {
            Console.WriteLine(motherBoard.InformationAbout());
        }

        if (cpu != null)
        {
            Console.WriteLine(cpu.InformationAbout());
        }

        if (gpu != null)
        {
            Console.WriteLine(gpu.InformationAbout());
        }

        if (rams != null)
        {
            foreach (var ram in rams)
            {
                Console.WriteLine(ram.InformationAbout());
            }
        }
        

        if (drives != null)
        {
            foreach (var drive in drives)
            {
                Console.WriteLine(drive.InformationAbout());
            }
        }
        
    }
    
    public void AddDetailToComputer()
    {
        while (true)
        {
            getInfo("computer");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    if (MotherBoard == null)
                    {
                        var motherBoard = new MotherBoard(0, "", "", "");
                        motherBoard.AddDetailByInput();
                        AddMotherBoard(motherBoard);
                    }
                    else
                    {
                        Console.WriteLine(MotherBoard.InformationAbout());
                        Console.WriteLine("|================|\n" +
                                          "You have added motherboard recently");
                    }
                    continue;
                case "2":
                    if (Cpu == null)
                    {
                        var cpu = new Cpu(0, "", "", "");
                        cpu.AddDetailByInput();
                        AddCpu(cpu);
                    }
                    else
                    {
                        Console.WriteLine(Cpu.InformationAbout());
                        Console.WriteLine("|================|\n" +
                                          "You have added cpu recently");
                    }
                    continue;
                case "3":
                    if (Gpu == null)
                    {
                        var gpu = new Gpu(0, "", "", "");
                        gpu.AddDetailByInput();
                        AddGpu(gpu);
                    }
                    else
                    {
                        Console.WriteLine(Gpu.InformationAbout());
                        Console.WriteLine("|================|\n" +
                                          "You have added gpu recently");
                    }
                    continue;
                case "4":
                    if (Rams == null)
                    {
                        Console.Write("How many rams does computer have: ");
                        var countRam = Convert.ToInt32(Console.ReadLine());
                        var rams = new List<Ram>(countRam);
                        for (int i = 0; i < countRam; i++)
                        {
                            Console.WriteLine($"\nEnter data of {i+1} ram");
                            var ram = new Ram(0, "", "", "");
                            ram.AddDetailByInput();
                            rams.Add(ram);
                        }
                        AddRam(rams);
                    }
                    else
                    {
                        foreach (var ram in Rams)
                        {
                            Console.WriteLine(ram.InformationAbout());
                        }
                        Console.WriteLine("|================|\n" + 
                                          "You have added ram recently");
                    }
                    continue;
                case "5":
                    if (Drives == null)
                    {
                        Console.Write("How many drives does computer have: ");
                        var countDrive = Convert.ToInt32(Console.ReadLine());
                        var drives = new List<Drive>(countDrive);
                        for (int i = 0; i < countDrive; i++)
                        {
                            Console.WriteLine($"\nEnter data of {i+1} drive");
                            
                            Console.Write("Which type of drive(HDD or SSD): ");
                            var typeDrive = Console.ReadLine();

                            switch (typeDrive)
                            {
                                case "HDD":
                                    var hdd = new Hdd(0, "", "", "");
                                    drives.Add(hdd);
                                    hdd.AddDetailByInput();
                                    AddDrive(drives);
                                    break;
                                case "SSD":
                                    var ssd = new Ssd(0, "", "", "");
                                    drives.Add(ssd);
                                    ssd.AddDetailByInput();
                                    AddDrive(drives);
                                    break;
                                default:
                                    Console.WriteLine("Wrong type of disk");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        foreach (var drive in Drives)
                        {
                            Console.WriteLine(drive.InformationAbout());
                        }
                        Console.WriteLine("|================|\n" + 
                                          "You have added drive recently");
                    }
                    continue;
                case "6":
                    getInfoAboutPC(MotherBoard, Cpu, Gpu, Rams, Drives);
                    continue;
                case "7":
                    VerificationOfWorking();
                    break;
            }
            break;
        }
    }

    public double SumBudgetOfDetails()
    {
        double budgetRams = 0;
        foreach (var ram in Rams)
        {
            budgetRams += Convert.ToDouble(ram.Price);
        }

        double budgetDrives = 0;
        foreach (var drive in Drives)
        {
            budgetDrives += Convert.ToDouble(drive.Price);
        }

        double budget = MotherBoard.Price + Cpu.Price + Gpu.Price + budgetRams + budgetDrives;
        return budget;
    }

    public void VerificationOfWorking()
    {
        try
        {
            if (CorrectRam() == true && CorrectCpu() == true && CorrectDrives() == true)
            {
                Console.WriteLine("Computer probably will work, as ram, cpu and drives are fitting to motherboard.");
            }
        }
        catch
        {
            Console.WriteLine("[FAIL] You didnt add some details to your pc");
        }
    }
}