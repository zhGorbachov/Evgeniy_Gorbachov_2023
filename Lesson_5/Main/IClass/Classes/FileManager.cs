using System.Text;
using Main.IClass.Interfaces;

namespace Main.IClass.Classes;

public class FileManager : IFileManager
{
    public string CreateFile(string directory, string name)
    {
        var path = Path.Combine(directory, name);
        
        var fileInfo = new FileInfo(path);
        
        if (!File.Exists(path))
        {
            using (FileStream fileStream = File.Create(path))
            {
                
            }
        }
        else
        {
            Console.Write($"File with it name {fileInfo.FullName} is exist, if you want to recreate it - print yes, or print any for continue working with it file: ");
            var userAnswer = Console.ReadLine();
            if (userAnswer == "yes" || userAnswer == "Yes")
            {
                File.Delete(path);
                using (FileStream fileStream = File.Create(path))
                {
                    
                }
            }
        } 
        
        return fileInfo.FullName;
    }

    public void GetFileInfo(string path)
    {
        if (CheckExistFile(path) == false)
        {
            return;
        }
        var info = new FileInfo(path);
        
        Console.WriteLine("| {0, -10} | {1, -20} | {2, -20} | {3, -20} | {4, -5} |\n|{5, 75}|",
            "Name", "Creation time", "Last changes time", "Directory name", "Size", String.Concat(Enumerable.Repeat("-", 89)));
        
        Console.WriteLine("| {0, -10} | {1, 20} | {2, 20} | {3, -20} | {4, -5} |\n|{5, 75}|",
            info.Name, info.CreationTime, info.LastWriteTime, info.DirectoryName, info.Length, String.Concat(Enumerable.Repeat("-", 89)));

    }
    
    public string MoveFile(string currentPath, string newPath)
    {
        if (CheckExistFile(currentPath) == false)
        {
            return null;
        }
        var fileInfo = new FileInfo(currentPath);

        var path = Path.Combine(newPath, fileInfo.Name);
        var fileInfoNew = new FileInfo(path);
        
        if (!fileInfoNew.Exists)
        {
            fileInfo.MoveTo(path);
        }
        else
        {
            Console.Write($"File with it name {fileInfo.FullName} is exist, if you want to recreate and move it - print yes, or print any for continue working with it file: ");
            var userAnswer = Console.ReadLine();
            if (userAnswer == "yes" || userAnswer == "Yes")
            {
                fileInfoNew.Delete();
                fileInfo.MoveTo(path);
            }
        }

        return fileInfo.FullName;
    }

    public string CopyFile(string currentPath, string newPath)
    {
        if (CheckExistFile(currentPath) == false)
        {
            return null;
        }
        var fileInfo = new FileInfo(currentPath);

        var path = Path.Combine(newPath, fileInfo.Name);
        var fileInfoNew = new FileInfo(path);

        
        if (!fileInfoNew.Exists)
        {
            fileInfo.CopyTo(path);
        }
        else
        {
            Console.Write($"File with it name {fileInfo.FullName} is exist, if you want to recreate and copy there - print yes, or print any for continue working with it file: ");
            var userAnswer = Console.ReadLine();
            if (userAnswer == "yes" || userAnswer == "Yes")
            {
                fileInfoNew.Delete();
                fileInfo.CopyTo(path);
            }
        }
        
        return fileInfo.FullName;
    }

    public void DeleteFile(string pathFile)
    {
        if (CheckExistFile(pathFile) == false)
        {
            return;
        }
        var fileInfo = new FileInfo(pathFile);

        if (fileInfo.Exists)
        {
            fileInfo.Delete();
            return;
        }
        Console.WriteLine("File doesnt exist.");
    }
    
    public void ReadFromFile(string path)
    {
        if (CheckExistFile(path) == false)
        {
            return;
        }
        using (FileStream fstream = File.OpenRead(path))
        {
            var bytes = new byte[fstream.Length];
            
            fstream.Read(bytes, 0, bytes.Length);

            string result = Encoding.Default.GetString(bytes);
            Console.WriteLine(result);
        }
    }
    
    public void WriteToFile(string path, string text)
    {
        if (CheckExistFile(path) == false)
        {
            return;
        }
        using FileStream fstream = new FileStream(path, FileMode.OpenOrCreate);
        var bytes = Encoding.Default.GetBytes(text);
            
        fstream.Write(bytes, 0, bytes.Length);
    }

    public bool CheckExistFile(string path)
    {
        var file = new FileInfo(path);
        if (!file.Exists)
        {
            Console.WriteLine("It file does not exist.");
            return false;
        }

        return true;
    }
    
    public void GetInformationAboutModules()
    {
        Console.WriteLine("|-------------------------------------------|\n" +
                          "| 1) Create file in this directory          |\n" +
                          "| 2) Move file from it dir to another       |\n" +
                          "| 3) Copy file from it dir to another       |\n" +
                          "| 4) Delete file from it directory          |\n" +
                          "| 5) Read from file                         |\n" +
                          "| 6) Write to file                          |\n" +
                          "| i) Information about file                 |\n" +
                          "| e) Go back                                |\n" +
                          "|-------------------------------------------|\n");
    }
}