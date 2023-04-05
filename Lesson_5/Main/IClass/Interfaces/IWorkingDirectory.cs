namespace Main.IClass.Interfaces;

public interface IWorkingDirectory
{
    public void GetInformationAboutDrives();

    public void PrintNameCurrentDirectory(string path);

    public void GetCurrentDirectoryFiles(string path);

    public void GetCurrentDirectoryFolders(string path);

    public void GetInformationAboutDirectory(string path);
    
    public string Cd(string? name, string current);
    
}