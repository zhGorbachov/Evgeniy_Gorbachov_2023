using System.Collections.ObjectModel;
using Main.IClass.Interfaces;

namespace Main.IClass.Classes;

public class ManagerDrives : IWorkingDirectory
{
    public void GetInformationAboutDrives()
    {
        var drives = DriveInfo.GetDrives();

        Console.WriteLine("| {0, -5} | {1, -5} | {2, -5} |\n|{3, -15}|", "Name", "Size", "Free", String.Concat(Enumerable.Repeat("-", 23)));
        foreach (var drive in drives)
        {
            Console.WriteLine("| {0, -5} | {1, -5} | {2, -5} |",
                drive.Name, Math.Round(drive.TotalSize * Math.Pow(10, -9)),
                Math.Round(drive.AvailableFreeSpace * Math.Pow(10, -9)));
        }
        
    }

    public void PrintNameCurrentDirectory(string path)
    {
        Console.WriteLine("| {0, -40} | {1, -10} |", path, "Type");
        Console.WriteLine("|{0, -40}|{1, -10}|", String.Concat(Enumerable.Repeat("-", 42)), String.Concat(Enumerable.Repeat("-", 12)));
    }
    
    public void GetCurrentDirectoryFiles(string path)
    {
        var files = Directory.GetFiles(path);
        
        for (int i = 0; i < files.Length; i++)
        {
            files[i] = files[i].Split("\\").Last().Split("/").Last();
            Console.WriteLine("| {0, -40} | {1, -10} |", files[i], "File");
        }
    }

    public void GetCurrentDirectoryFolders(string path)
    {
        var folders = Directory.GetDirectories(path);
        
        for (int i = 0; i < folders.Length; i++)
        {
            folders[i] = folders[i].Split('\\').Last().Split("/").Last() + "/";
            Console.WriteLine("| {0, -40} | {1, -10} |", folders[i], "Folder");
        }
    }

    public void GetInformationAboutDirectory(string path)
    {
        PrintNameCurrentDirectory(path);
        GetCurrentDirectoryFolders(path);
        GetCurrentDirectoryFiles(path);
    }
    
    public string Cd(string? name, string current)
    {
        var info = new DirectoryInfo(current);
        if (name == "./")
        {
            
            if (info.FullName != current)
            {
                var parentDirectory = info.Parent;
                
                return parentDirectory is not null ? parentDirectory.FullName : current;
            }
            
            return current;
        }

        if (name == "..")
        {
            var splitedPath = current.Split("\\");

            splitedPath = splitedPath.SkipLast(1).ToArray();
            
            var path = String.Join("//", splitedPath);

            if (path == "")
            {
                var drives = DriveInfo.GetDrives().First();
                path = drives.Name;
            }
            
            return path;
        }
        
        var dir = Path.Combine(current, name);

        if (Directory.Exists(dir))
        {
            return dir;
        }
        Console.WriteLine($"Its directory doesnt exist: {dir}");
        return current;
    }

    public bool CheckExistDir(string path)
    {
        var directory = new DirectoryInfo(path);
        
        
        if (!directory.Exists)
        {
            return false;
        }

        return true;
    }

    public void GetInformationAboutModules()
    {
        Console.WriteLine("|-------------------------------------------|\n" +
                          "| 1) Information about your drives          |\n" +
                          "| 2) Get all information about directory    |\n" +
                          "| e) Go back                                |\n" +
                          "|-------------------------------------------|\n");
    }
}