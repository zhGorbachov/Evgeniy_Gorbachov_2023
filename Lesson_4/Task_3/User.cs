namespace LiskovSubstitution;

public class User : IUser
{
    public string ReadFromFile(string filename)
    {
        Console.WriteLine("File read");
        return null;
    }

    public void DownloadFile(string filename)
    {
        Console.WriteLine("File downloaded");
    }

    public void CopyFile(string filename)
    {
        Console.WriteLine("File copied");
    }

    public Guid CheckRole(Guid role)
    {
        return Guid.NewGuid();
    }
}