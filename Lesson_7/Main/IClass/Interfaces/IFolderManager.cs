namespace Main.IClass.Interfaces;

public interface IFolderManager
{
    public string CreateFolder(string directory, string name);
    public void GetFolder(string path);
    public Task<string> MoveFolderAsync(string currentPath, string newPath, string disk);
    public Task<string> CopyFolderAsync(string currentPath, string newPath, string disk);
    public Task<string> DeleteFolderAsync(string pathFolder);
    public Task GetInformationAboutModules();
}