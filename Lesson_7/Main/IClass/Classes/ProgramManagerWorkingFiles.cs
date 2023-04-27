namespace Main.IClass.Classes;

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
    
    public static async void ProgramStart()
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
            
            if (Path.Last() != '/' && Path.Last() != '\\') 
                Path += '/';

            if (driveManager.CheckExistDir(Path) == false)
            {
                Console.WriteLine("It directory does not exist. Directory was changed on drive.");
                Path = drives.First().Name;
                continue;
            }
            
            switch (userAnswer)
            {
                case "1":
                    driveManager.GetInformationAboutDirectory(Path);
                    Console.Write(Path);
                    var userPath = Console.ReadLine();

                    Path = driveManager.Cd(userPath, Path);
                    
                    continue;
                case "2":
                    fileManager.GetInformationAboutModules();

                    Console.WriteLine("You need to be in a directory with function cd to choose some file: ");
                    FilePath = Path;

                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            Console.Write("Enter name of file: ");
                            var nameFile = Console.ReadLine();
                            fileManager.CreateFile(Path, nameFile);

                            break;
                        case "2":
                            Console.Write("Enter a name of file which you move: ");
                            FilePath += Console.ReadLine();

                            Console.Write("Enter a directory where you want to move file: ");
                            var filePathMove = Console.ReadLine();
                            
                            if (driveManager.CheckExistDir(filePathMove) == false)
                                break;

                            await fileManager.MoveFileAsync(FilePath, filePathMove);

                            break;
                        case "3":
                            Console.Write("Enter a name of file which you want to copy: ");
                            FilePath += Console.ReadLine();

                            Console.Write("Enter a directory where you want to copy file: ");
                            var filePathCopy = Console.ReadLine();
                            
                            if (driveManager.CheckExistDir(filePathCopy) == false)
                                break;
                            
                            await fileManager.CopyFileAsync(FilePath, filePathCopy);

                            break;
                        case "4":
                            Console.Write("Enter a name of file which you want to delete: ");
                            FilePath += Console.ReadLine();
                            
                            await fileManager.DeleteFileAsync(FilePath);

                            break;
                        case "5":
                            Console.Write("You need to give name of file: ");
                            FilePath += Console.ReadLine();
                            
                            await fileManager.ReadFromFileAsync(FilePath);

                            break;
                        case "6":
                            Console.Write("Enter name of file: ");
                            FilePath += Console.ReadLine();
                            
                            Console.Write("Enter text: ");
                            var textFile = Console.ReadLine();
                            await fileManager.WriteToFileAsync(FilePath, textFile);

                            break;
                        case "i":
                            Console.Write("Enter a name of file: ");
                            FilePath += Console.ReadLine();
                            
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
                            Path = folderManager.CreateFolder(Path, nameFolder);

                            break;
                        case "2":
                            Console.Write("Enter your new path: ");
                            var newPathMove = Console.ReadLine();
                            Path = await folderManager.MoveFolderAsync(Path, newPathMove, drives.First().Name);

                            break;
                        case "3":
                            Console.Write("Enter you new path: ");
                            var newPathCopy = Console.ReadLine();
                            Path = await folderManager.CopyFolderAsync(Path, newPathCopy, drives.First().Name);

                            break;
                        case "4":
                            await folderManager.DeleteFolderAsync(Path);

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
                
            }

            break;
        }
    }
}