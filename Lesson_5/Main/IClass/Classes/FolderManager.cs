﻿
namespace Main.IClass.Classes;

public class FolderManager
{
    public string CreateFolder(string directory, string name)
    {
        var path = Path.Combine(directory, name);
        
        var folderInfo = new DirectoryInfo(path);
        
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        else
        {
            Console.Write($"Directory with it name {folderInfo.FullName} is exist, if you want to recreate it - print yes, or print any for continue working with it folder: ");
            var userAnswer = Console.ReadLine();
            if (userAnswer == "yes" || userAnswer == "Yes")
            {
                Directory.Delete(path);
                Directory.CreateDirectory(path);
            }
        } 
        
        return folderInfo.FullName;
    }

    public void GetFolderInfo(string path)
    {
        var folderInfo = new DirectoryInfo(path);
        
        if (!folderInfo.Exists)
        {
            Console.WriteLine("Folder does not exist.");
            return;
        }
        
        Console.WriteLine("| {0, -10} | {1, -20} | {2, -20} | {3, -20} |\n|{4, 75}|",
                    "Name", "Creation time", "Last changes time", "Folder directory", String.Concat(Enumerable.Repeat("-", 81)));
        
        Console.WriteLine("| {0, -10} | {1, 20} | {2, 20} | {3, -20} |\n|{4, 75}|",
            folderInfo.Name, folderInfo.CreationTime, folderInfo.LastWriteTime, folderInfo.FullName, String.Concat(Enumerable.Repeat("-", 81)));
    }
    
    public string MoveFolder(string currentPath, string newPath, string disk)
    {
        var folderInfo = new DirectoryInfo(currentPath);

        var path = Path.Combine(newPath, folderInfo.Name);
        var folderInfoNew = new DirectoryInfo(path);

        if (!folderInfo.Exists)
        {
            Console.WriteLine("Folder does not exist.");
            return disk;
        }
        
        if (!folderInfoNew.Exists)
        {
            folderInfo.MoveTo(path);
        }
        else
        {
            Console.Write($"Folder with it name {folderInfo.FullName} is exist, if you want to recreate and move it - print yes, or print any for continue working with it folder: ");
            var userAnswer = Console.ReadLine();
            if (userAnswer == "yes" || userAnswer == "Yes")
            {
                folderInfoNew.Delete();
                folderInfo.MoveTo(path);
            }
        }

        return folderInfoNew.FullName;
    }

    public string CopyFolder(string currentPath, string newPath, string disk)
    {
        var folderInfo = new DirectoryInfo(currentPath);
        
        var path = Path.Combine(newPath, folderInfo.Name);
        var folderInfoNew = new DirectoryInfo(path);
        
        if (!folderInfo.Exists)
        {
            Console.WriteLine("Folder does not exist.");
            return disk;
        }
        
        if (!folderInfoNew.Exists)
        {
            var folders = new List<DirectoryInfo>(folderInfo.GetDirectories());
            Directory.CreateDirectory(path);
            
            foreach (var file in folderInfo.GetFiles())
            {
                var targetFilePath = Path.Combine(path, file.Name);
                file.CopyTo(targetFilePath);
            }
            
            foreach (var subFolder in folders)
            {
                CopyFolder(subFolder.FullName, path, disk);
            }
        }
        else
        {
            Console.Write($"File with it name {folderInfo.FullName} is exist, if you want to recreate and copy there - print yes, or print any for continue working with it file: ");
            var userAnswer = Console.ReadLine();
            
            if (userAnswer == "yes" || userAnswer == "Yes")
            {
                DeleteFolder(path);
                var folders = new List<DirectoryInfo>(folderInfo.GetDirectories());
                Directory.CreateDirectory(path);
            
                foreach (var file in folderInfo.GetFiles())
                {
                    var targetFilePath = Path.Combine(path, file.Name);
                    file.CopyTo(targetFilePath);
                }
            
                foreach (var subFolder in folders)
                {
                    CopyFolder(subFolder.FullName, path, disk);
                }
            }
        }

        return folderInfoNew.FullName;
    }

    public void DeleteFolder(string pathFolder)
    {
        var folderInfo = new DirectoryInfo(pathFolder);
        var drives = DriveInfo.GetDrives();
        
        var count = 0;
        foreach (var drive in drives)
        {
            if (drive.Name == pathFolder)
            {
                Console.WriteLine("Nu-nu-nu... You need to be in a folder to delete it.");
                break;
            }
            count++;
        }

        if (count == drives.Length)
        {
            if (folderInfo.Exists)
            {
                folderInfo.Delete(true);
                return;
            }
            Console.WriteLine("Folder doesnt exist.");
        }
    }
    public void GetInformationAboutModules()
    {
        Console.WriteLine("|-------------------------------------------|\n" +
                          "| 1) Create folder in this dir              |\n" +
                          "| 2) Move folder to another directory       |\n" +
                          "| 3) Copy folder from it dir to another     |\n" +
                          "| 4) Delete folder from it directory        |\n" +
                          "| i) Information about folder               |\n" +
                          "| e) Go back                                |\n" +
                          "|-------------------------------------------|\n");
    }
}