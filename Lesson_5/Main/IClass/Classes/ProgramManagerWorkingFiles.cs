﻿namespace Main.IClass.Classes;

public static class ProgramManagerWorkingFiles
{

    public static string Path { get; set; } = @"C:\";
    public static string FilePath { get; set; }
    
    public static void GetInfoAboutProgram()
    {
        Console.WriteLine("\n|-------------------------------------------|\n" +
                          "|Program which working with file on your pc!|\n" +
                          "|    Choose any number or letter to work    |\n" +
                          "| 1) Moving to cd across the system(cd)     |\n" +
                          "| 2) Start working with file                |\n" +
                          "| 3) Start working with folder              |\n" +
                          "| i) Get information about your path        |\n" +
                          "| e) Exit program                           |\n" +
                          "|-------------------------------------------|\n");
    }
    
    public static void ProgramStart()
    { 
        while (true)
        {
            var driveManager = new ManagerDrives();
            var folderManager = new FolderManager();
            var fileManager = new FileManager();
            var drives = DriveInfo.GetDrives();
            string userInput;
            
            GetInfoAboutProgram();
            
            var userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "1":
                    driveManager.GetInformationAboutDirectory(Path);

                    if (Path.Last() != '/' && Path.Last() != '\\')
                        Path += '/';

                    Console.Write(Path);
                    var userPath = Console.ReadLine();

                    Path = driveManager.Cd(userPath, Path);

                    continue;
                case "2":
                    fileManager.GetInformationAboutModules();

                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            Console.Write("Enter name of file: ");
                            var nameFile = Console.ReadLine();
                            FilePath = fileManager.CreateFile(Path, nameFile);

                            break;
                        case "2":
                            Console.Write("Enter a full path to file which you move: ");
                            FilePath = Console.ReadLine();

                            Console.Write("Enter a directory where you want to move file: ");
                            var filePathMove = Console.ReadLine();
                            FilePath = fileManager.MoveFile(FilePath, filePathMove);

                            break;
                        case "3":
                            Console.Write("Enter a full path to file which you want to copy: ");
                            FilePath = Console.ReadLine();

                            Console.Write("Enter a directory where you want to copy file: ");
                            var filePathCopy = Console.ReadLine();
                            FilePath = fileManager.CopyFile(FilePath, filePathCopy);

                            break;
                        case "4":
                            Console.Write("Enter a full path to file which you want to delete: ");
                            FilePath = Console.ReadLine();
                            fileManager.DeleteFile(FilePath);

                            break;
                        case "5":
                            Console.Write("You need to give full path to file: ");
                            FilePath = Console.ReadLine();
                            fileManager.ReadFromFile(FilePath);

                            break;
                        case "6":
                            Console.Write("Enter full path to file: ");
                            FilePath = Console.ReadLine();

                            Console.Write("Enter text: ");
                            var textFile = Console.ReadLine();
                            fileManager.WriteToFile(FilePath, textFile);

                            break;
                        case "i":
                            Console.Write("Enter a full path to file: ");
                            FilePath = Console.ReadLine();

                            fileManager.GetFileInfo(FilePath);
                            break;
                        case "e":
                            break;
                    }

                    continue;
                case "3":
                    folderManager.GetInformationAboutModules();
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            Console.Write("Enter name of folder: ");
                            var nameFolder = Console.ReadLine();
                            folderManager.CreateFolder(Path, nameFolder);

                            break;
                        case "2":
                            Console.Write("Enter your new path: ");
                            var newPathMove = Console.ReadLine();
                            Path = folderManager.MoveFolder(Path, newPathMove);

                            break;
                        case "3":
                            Console.Write("Enter you new path: ");
                            var newPathCopy = Console.ReadLine();
                            Path = folderManager.CopyFolder(Path, newPathCopy);

                            break;
                        case "4":
                            var count = 0;
                            foreach (var drive in drives)
                            {
                                if (drive.Name == Path)
                                {
                                    Console.WriteLine("Nu-nu-nu... You need to be in a folder to delete it.");
                                    break;
                                }
                                count++;
                            }
                            if (count == drives.Length)
                                folderManager.DeleteFolder(Path);

                            break;
                        case "i":
                            folderManager.GetFolderInfo(Path);

                            break;
                        case "e":
                            break;
                    }

                    continue;
                case "i":
                    driveManager.GetInformationAboutModules();

                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            driveManager.GetInformationAboutDrives();
                            Thread.Sleep(2000);
                            break;
                        case "2":
                            driveManager.GetInformationAboutDirectory(Path);
                            Thread.Sleep(2000);
                            break;
                        case "e":
                            break;
                    }

                    continue;
                case "e":
                    break;

                default:
                    break;
            }

            break;
        }
    }
}