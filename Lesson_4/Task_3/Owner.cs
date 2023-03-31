namespace LiskovSubstitution;

public class Owner : IOwner
{
    public void GetDataFromFile(string filename)
    {
        Console.WriteLine("Data got from file");
    }
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
    public void WriteToFile(string filename)
    {
        Console.WriteLine("File wrote");
    }

    public void DeleteFile(string filename)
    {
        Console.WriteLine("File deleted");
    }

    public void CheckFile(string filename)
    {
        Console.WriteLine("File checked");
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine("File saved");
    }

    public Guid CheckUser(Guid user)
    {
        Console.WriteLine("User checked");
        return Guid.NewGuid();
    }
}