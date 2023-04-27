namespace Main.IClass.Interfaces;

public interface IFileManager
{
    public string CreateFile(string dir, string name);
    public void GetFileInfo(string path);
    public Task<string> MoveFileAsync(string filePath, string newPath);
    public Task<string> CopyFileAsync(string currentPath, string newPath);
    public Task DeleteFileAsync(string pathFile);
    public Task ReadFromFileAsync(string path);
    public Task WriteToFileAsync(string path, string text);
}