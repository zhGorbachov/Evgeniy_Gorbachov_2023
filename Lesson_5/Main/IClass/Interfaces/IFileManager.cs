namespace Main.IClass.Interfaces;

public interface IFileManager
{
    public string CreateFile(string dir, string name);
    public void GetFileInfo(string path);
    public string MoveFile(string filePath, string newPath);
    public string CopyFile(string currentPath, string newPath);
    public void DeleteFile(string pathFile);
    public void ReadFromFile(string path);
    public void WriteToFile(string path, string text);
}